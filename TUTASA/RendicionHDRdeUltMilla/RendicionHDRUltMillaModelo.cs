using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUTASA.Almacenes;

namespace TUTASA.RendicionHDRdeUltMilla
{
    internal class RendicionHDRUltMillaModelo
    {
        public Fletero FleteroActual { get; set; } = null;
        public List<HDR> HdrsRendidas { get; set; } = new List<HDR>();

        // CD activo de sesión (hardcodeado por ahora)
        private int idCDSesion = 1; // CD Buenos Aires

        // Busca un fletero por DNI
        public Fletero BuscarFleteroPorDNI(string dni)
        {
            foreach (FleteroEntidad fleteroEntidad in FleteroAlmacen.fleteros)
            {
                if (fleteroEntidad.DniFletero.ToString() == dni)
                {
                    return new Fletero
                    {
                        Id = fleteroEntidad.IdFletero,
                        NombreCompleto = fleteroEntidad.NombreFletero + " " + fleteroEntidad.ApellidoFletero,
                        DNI = fleteroEntidad.DniFletero.ToString()
                    };
                }
            }
            return null;
        }

        // Devuelve las HDRs en estado Pendiente asignadas al fletero (informativo)
        public List<HDR> ObtenerHDRsPendientesPorFletero(int idFletero)
        {
            var resultado = new List<HDR>();

            foreach (HDRRetiroEntidad hdrRetiro in HDRRetiroAlmacen.hDRRetiros)
            {
                if (hdrRetiro.IdFletero == idFletero && hdrRetiro.EstadoHDR == EstadoHDRUltimaMillaEnum.Pendiente)
                {
                    resultado.Add(new HDR
                    {
                        Id = (int)hdrRetiro.IdHDRdeRetiro,
                        NroHDR = "RET-" + hdrRetiro.IdHDRdeRetiro.ToString("D6"),
                        Estado = "Pendiente",
                        TipoHDR = "Retiro",
                        IdFletero = hdrRetiro.IdFletero
                    });
                }
            }

            foreach (HDREntregaEntidad hdrEntrega in HDREntregaAlmacen.hDREntregas)
            {
                if (hdrEntrega.IdFletero == idFletero && hdrEntrega.EstadoHDR == EstadoHDRUltimaMillaEnum.Pendiente)
                {
                    resultado.Add(new HDR
                    {
                        Id = (int)hdrEntrega.IdHDRdeEntrega,
                        NroHDR = "ENT-" + hdrEntrega.IdHDRdeEntrega.ToString("D6"),
                        Estado = "Pendiente",
                        TipoHDR = "Entrega",
                        IdFletero = hdrEntrega.IdFletero
                    });
                }
            }

            return resultado;
        }

        // Devuelve las HDRs en estado EnProceso asignadas al fletero (para rendir)
        public List<HDR> ObtenerHDRsEnProcesoPorFletero(int idFletero)
        {
            var resultado = new List<HDR>();

            foreach (HDRRetiroEntidad hdrRetiro in HDRRetiroAlmacen.hDRRetiros)
            {
                if (hdrRetiro.IdFletero == idFletero && hdrRetiro.EstadoHDR == EstadoHDRUltimaMillaEnum.EnProceso)
                {
                    resultado.Add(new HDR
                    {
                        Id = (int)hdrRetiro.IdHDRdeRetiro,
                        NroHDR = "RET-" + hdrRetiro.IdHDRdeRetiro.ToString("D6"),
                        Estado = "EnProceso",
                        TipoHDR = "Retiro",
                        IdFletero = hdrRetiro.IdFletero
                    });
                }
            }

            foreach (HDREntregaEntidad hdrEntrega in HDREntregaAlmacen.hDREntregas)
            {
                if (hdrEntrega.IdFletero == idFletero && hdrEntrega.EstadoHDR == EstadoHDRUltimaMillaEnum.EnProceso)
                {
                    resultado.Add(new HDR
                    {
                        Id = (int)hdrEntrega.IdHDRdeEntrega,
                        NroHDR = "ENT-" + hdrEntrega.IdHDRdeEntrega.ToString("D6"),
                        Estado = "EnProceso",
                        TipoHDR = "Entrega",
                        IdFletero = hdrEntrega.IdFletero
                    });
                }
            }

            return resultado;
        }

        // Registra la rendicion de una HDR
        public void RendirHDR(HDR hdr, bool cumplida)
        {
            hdr.Estado = cumplida ? "Cumplida" : "NoCumplida";
        }

        // Revierte el estado de una HDR a EnProceso cuando es quitada
        public void RevertirHDR(HDR hdr)
        {
            hdr.Estado = "EnProceso";
        }

        // Confirma la rendicion
        public void ConfirmarRendicion(List<HDR> hdrsAConfirmar, int idFletero)
        {
            DateTime ahora = DateTime.Now;

            foreach (var hdr in hdrsAConfirmar)
            {
                bool cumplida = hdr.Estado == "Cumplida";

                if (hdr.TipoHDR == "Retiro")
                {
                    foreach (HDRRetiroEntidad hdrEntidad in HDRRetiroAlmacen.hDRRetiros)
                    {
                        if (hdrEntidad.IdHDRdeRetiro == hdr.Id)
                        {
                            hdrEntidad.EstadoHDR = cumplida
                                ? EstadoHDRUltimaMillaEnum.Cumplida
                                : EstadoHDRUltimaMillaEnum.NoCumplida;

                            // Actualizar guias
                            foreach (int idGuia in hdrEntidad.GuiasRetiro)
                            {
                                foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
                                {
                                    if (guiaEntidad.IdGuia == idGuia)
                                    {
                                        EstadoGuiaEnum nuevoEstado = cumplida
                                            ? EstadoGuiaEnum.PreAdmitida
                                            : EstadoGuiaEnum.Cancelada;

                                        guiaEntidad.EstadoGuia = nuevoEstado;
                                        guiaEntidad.Historial.Add(new HistorialGuia
                                        {
                                            Estado = nuevoEstado,
                                            Fecha = ahora
                                        });

                                        // Registrar comision fletero de retiro si fue cumplida
                                        if (cumplida && guiaEntidad.IdComisionFletero > 0)
                                        {
                                            decimal montoFletero = 0;
                                            foreach (ComisionFleteroEntidad cf in ComisionFleteroAlmacen.comisionFleteros)
                                            {
                                                if (cf.IdComisionFletero == guiaEntidad.IdComisionFletero)
                                                {
                                                    montoFletero = cf.MontoComision;
                                                    break;
                                                }
                                            }

                                            int nuevoIdFletero = CtaCteFleteroAlmacen.ctaCteFleteros.Count + 1;
                                            CtaCteFleteroAlmacen.ctaCteFleteros.Add(new CtaCteFleteroEntidad
                                            {
                                                IdMovimientoFletero = nuevoIdFletero,
                                                IdFletero = FleteroActual.Id,
                                                IdGuia = guiaEntidad.IdGuia,
                                                Pagado = false,
                                                Importe = montoFletero,
                                                FechaMovimiento = ahora
                                            });
                                        }
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    }
                    if (cumplida)
                        CtaCteFleteroAlmacen.Guardar();
                }
                else if (hdr.TipoHDR == "Entrega")
                {
                    foreach (HDREntregaEntidad hdrEntidad in HDREntregaAlmacen.hDREntregas)
                    {
                        if (hdrEntidad.IdHDRdeEntrega == hdr.Id)
                        {
                            hdrEntidad.EstadoHDR = cumplida
                                ? EstadoHDRUltimaMillaEnum.Cumplida
                                : EstadoHDRUltimaMillaEnum.NoCumplida;

                            // Actualizar guias
                            foreach (int idGuia in hdrEntidad.GuiasEntrega)
                            {
                                foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
                                {
                                    if (guiaEntidad.IdGuia == idGuia)
                                    {
                                        EstadoGuiaEnum nuevoEstado = guiaEntidad.EstadoGuia;

                                        if (cumplida)
                                        {
                                            if (guiaEntidad.TipoEntrega == TipoEntregaEnum.Domicilio)
                                            {
                                                nuevoEstado = EstadoGuiaEnum.Entregada;
                                                RegistrarMovimientosEntrega(guiaEntidad, ahora);
                                            }
                                            else if (guiaEntidad.TipoEntrega == TipoEntregaEnum.Agencia)
                                            {
                                                nuevoEstado = EstadoGuiaEnum.DisponibleParaEntrega;
                                            }
                                        }
                                        else
                                        {
                                            // Si no se cumplió la entrega, verificar si ya hubo un intento fallido previo para decidir si va a IntentoFallido o Cancelada
                                            bool yaHuboIntentoFallido = false;
                                            foreach (var h in guiaEntidad.Historial)
                                            {
                                                if (h.Estado == EstadoGuiaEnum.IntentoDeEntregaFallido)
                                                {
                                                    yaHuboIntentoFallido = true;
                                                    break;
                                                }
                                            }

                                            if (yaHuboIntentoFallido)
                                            {
                                                nuevoEstado = EstadoGuiaEnum.Cancelada;
                                                CrearGuiaDevolucion(guiaEntidad, ahora);
                                            }
                                            else
                                            {
                                                nuevoEstado = EstadoGuiaEnum.IntentoDeEntregaFallido;
                                            }
                                        }

                                        guiaEntidad.EstadoGuia = nuevoEstado;
                                        guiaEntidad.Historial.Add(new HistorialGuia
                                        {
                                            Estado = nuevoEstado,
                                            Fecha = ahora
                                        });
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    }
                }
            }

            // Pasar las HDRs pendientes del fletero a EnProceso
            foreach (HDRRetiroEntidad hdrRetiro in HDRRetiroAlmacen.hDRRetiros)
            {
                if (hdrRetiro.IdFletero == idFletero && hdrRetiro.EstadoHDR == EstadoHDRUltimaMillaEnum.Pendiente)
                    hdrRetiro.EstadoHDR = EstadoHDRUltimaMillaEnum.EnProceso;
            }

            foreach (HDREntregaEntidad hdrEntrega in HDREntregaAlmacen.hDREntregas)
            {
                if (hdrEntrega.IdFletero == idFletero && hdrEntrega.EstadoHDR == EstadoHDRUltimaMillaEnum.Pendiente)
                    hdrEntrega.EstadoHDR = EstadoHDRUltimaMillaEnum.EnProceso;
            }

            HDRRetiroAlmacen.Guardar();
            HDREntregaAlmacen.Guardar();
            GuiaAlmacen.Guardar();
        }

        private void RegistrarMovimientosEntrega(GuiaEntidad guia, DateTime ahora)
        {
            // Cuenta corriente cliente
            int nuevoIdCliente = CtaCteClienteAlmacen.ctaCteClientes.Count + 1;
            CtaCteClienteAlmacen.ctaCteClientes.Add(new CtaCteClienteEntidad
            {
                IdMovimientoCliente = nuevoIdCliente,
                IdCliente = guia.IdCliente,
                IdGuia = guia.IdGuia,
                Facturado = false,
                Importe = guia.TarifaDefinitiva,
                FechaMovimiento = ahora
            });

            // Cuenta corriente fletero
            if (guia.IdComisionFletero > 0)
            {
                decimal montoFletero = 0;
                foreach (ComisionFleteroEntidad cf in ComisionFleteroAlmacen.comisionFleteros)
                {
                    if (cf.IdComisionFletero == guia.IdComisionFletero)
                    {
                        montoFletero = cf.MontoComision;
                        break;
                    }
                }

                int nuevoIdFletero = CtaCteFleteroAlmacen.ctaCteFleteros.Count + 1;
                CtaCteFleteroAlmacen.ctaCteFleteros.Add(new CtaCteFleteroEntidad
                {
                    IdMovimientoFletero = nuevoIdFletero,
                    IdFletero = FleteroActual.Id,
                    IdGuia = guia.IdGuia,
                    Pagado = false,
                    Importe = montoFletero,
                    FechaMovimiento = ahora
                });
            }

            // Cuenta corriente agencia
            if (guia.IdComisionAgencia > 0 && guia.IdAgenciaOrigen > 0)
            {
                decimal montoAgencia = 0;
                foreach (ComisionAgenciaEntidad ca in ComisionAgenciaAlmacen.comisionAgencias)
                {
                    if (ca.IdComisionAgencia == guia.IdComisionAgencia)
                    {
                        montoAgencia = ca.MontoComision;
                        break;
                    }
                }

                int nuevoIdAgencia = CtaCteAgenciaAlmacen.ctaCteAgencias.Count + 1;
                CtaCteAgenciaAlmacen.ctaCteAgencias.Add(new CtaCteAgenciaEntidad
                {
                    IdMovimientoAgencia = nuevoIdAgencia,
                    IdAgencia = guia.IdAgenciaOrigen,
                    IdGuia = guia.IdGuia,
                    Pagado = false,
                    Importe = montoAgencia,
                    FechaMovimiento = ahora
                });
            }

            CtaCteClienteAlmacen.Guardar();
            CtaCteFleteroAlmacen.Guardar();
            CtaCteAgenciaAlmacen.Guardar();
        }

        // Crea una guia de devolucion cuando se cancela por 2do intento fallido
        private void CrearGuiaDevolucion(GuiaEntidad guiaOriginal, DateTime ahora)
        {
            int nuevoId = GuiaAlmacen.guias.Count + 1;
            string nroTracking = idCDSesion + "-DEV-" + nuevoId.ToString("D6");

            // Determinar destino segun como fue impuesta originalmente
            int idAgenciaDestino = 0;
            int idCDDestino = 0;
            TipoEntregaEnum tipoEntregaDevolucion;

            if (guiaOriginal.IdAgenciaOrigen > 0)
            {
                // Fue impuesta en agencia → devolver a esa agencia
                idAgenciaDestino = guiaOriginal.IdAgenciaOrigen;
                tipoEntregaDevolucion = TipoEntregaEnum.Agencia;
            }
            else if (guiaOriginal.RemDni > 0)
            {
                // Fue impuesta en call center → devolver al domicilio de retiro original
                tipoEntregaDevolucion = TipoEntregaEnum.Domicilio;
            }
            else
            {
                // Fue impuesta en CD → devolver al CD origen
                idCDDestino = guiaOriginal.IdCDOrigen;
                tipoEntregaDevolucion = TipoEntregaEnum.CD;
            }

            GuiaEntidad guiaDevolucion = new GuiaEntidad
            {
                IdGuia = nuevoId,
                NroTracking = nroTracking,
                IdCliente = guiaOriginal.IdCliente,
                FechaImposicion = ahora,
                TipoEntrega = tipoEntregaDevolucion,
                IdAgenciaOrigen = 0,
                IdCDOrigen = idCDSesion,
                CategoriaBulto = guiaOriginal.CategoriaBulto,
                RemDni = 0,
                RemDomicilioRetiro = string.Empty,
                RemCodPostal = string.Empty,
                DniDestinatario = guiaOriginal.RemDni,
                NombreApellidoDestinatario = "DEVOLUCION - " + guiaOriginal.NombreApellidoDestinatario,
                TelefonoDestinatario = 0,
                DomicilioEntrega = guiaOriginal.RemDomicilioRetiro,
                DomicilioEntregaCodPostal = guiaOriginal.RemCodPostal,
                IdAgenciaDestino = idAgenciaDestino,
                IdCDDestino = idCDDestino,
                IdTarifaCliente = 0,
                IdExtras = 0,
                TarifaDefinitiva = 0,
                TieneExtraRetiro = false,
                TieneExtraEntregaDomicilio = tipoEntregaDevolucion == TipoEntregaEnum.Domicilio,
                TieneExtraEntregaAgencia = tipoEntregaDevolucion == TipoEntregaEnum.Agencia,
                EstadoGuia = EstadoGuiaEnum.Admitida,
                Historial = new List<HistorialGuia>
                {
                    new HistorialGuia { Estado = EstadoGuiaEnum.Admitida, Fecha = ahora }
                }
            };

            GuiaAlmacen.guias.Add(guiaDevolucion);
        }
    }
}
