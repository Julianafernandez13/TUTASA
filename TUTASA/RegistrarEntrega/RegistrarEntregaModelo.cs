using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TUTASA.Almacenes;

namespace TUTASA.RegistrarEntrega
{
    internal class RegistrarEntregaModelo
    {
        private CentroDistribucionEntidad cdActivo
        {
            get
            {
                int cdActivoId = Program.CdActivoId;
                foreach (CentroDistribucionEntidad cd in CentroDistribucionAlmacen.centroDistribucions)
                {
                    if (cd.IdCD == cdActivoId)
                        return cd;
                }
                return null;
            }
        }

        private AgenciaEntidad agenciaActiva
        {
            get
            {
                int agenciaActivaId = Program.AgenciaActivaId;
                foreach (AgenciaEntidad agencia in AgenciaAlmacen.agencias)
                {
                    if (agencia.IdAgencia == agenciaActivaId)
                        return agencia;
                }
                return null;
            }
        }

        public Receptor ReceptorSeleccionado { get; private set; }
        public List<GuiaEntrega> GuiasDisponibles { get; private set; } = new List<GuiaEntrega>();

        internal bool BuscarReceptor(string dni)
        {
            ReceptorSeleccionado = null;
            GuiasDisponibles = new List<GuiaEntrega>();

            if (!long.TryParse(dni.Trim(), out long dniLong))
                return false;

            var guiasEncontradas = new List<GuiaEntrega>();

            foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
            {
                if (guiaEntidad.EstadoGuia != EstadoGuiaEnum.DisponibleParaEntrega)
                    continue;

                if (guiaEntidad.DniDestinatario != dniLong)
                    continue;

                // Filtro segun tipo de entrega y sesion activa
                bool esDeSesion = false;

                if (guiaEntidad.TipoEntrega == TipoEntregaEnum.CD && guiaEntidad.IdCDDestino == cdActivo.IdCD)
                {
                    esDeSesion = true;
                }
                else if (guiaEntidad.TipoEntrega == TipoEntregaEnum.Agencia && guiaEntidad.IdAgenciaDestino == agenciaActiva.IdAgencia)
                {
                    esDeSesion = true;
                }

                if (!esDeSesion)
                    continue;

                var guia = new GuiaEntrega();
                guia.Id = guiaEntidad.IdGuia;
                guia.NroTracking = guiaEntidad.NroTracking;
                guia.NombreDestinatario = guiaEntidad.NombreApellidoDestinatario;

                if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.S) guia.Categoria = "S";
                else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.M) guia.Categoria = "M";
                else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.L) guia.Categoria = "L";
                else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.XL) guia.Categoria = "XL";

                
                foreach (ClienteEntidad clienteEntidad in ClienteAlmacen.clientes)
                {
                    if (clienteEntidad.IdCliente == guiaEntidad.IdCliente)
                    {
                        guia.NombreCliente = clienteEntidad.NombreCliente + " " + clienteEntidad.ApellidoCliente;
                        break;
                    }
                }

                guiasEncontradas.Add(guia);
            }

            if (guiasEncontradas.Count == 0)
                return false;

            ReceptorSeleccionado = new Receptor
            {
                Dni = dni.Trim(),
                NombreCompleto = guiasEncontradas[0].NombreDestinatario
            };

            GuiasDisponibles = guiasEncontradas;
            return true;
        }

        internal bool ConfirmarEntrega()
        {
            if (ReceptorSeleccionado == null || GuiasDisponibles.Count == 0)
                return false;

            DateTime ahora = DateTime.Now;

            foreach (var guia in GuiasDisponibles)
            {
                foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
                {
                    if (guiaEntidad.IdGuia == guia.Id)
                    {
                        // Actualizar estado
                        guiaEntidad.EstadoGuia = EstadoGuiaEnum.Entregada;
                        guiaEntidad.Historial.Add(new HistorialGuia
                        {
                            Estado = EstadoGuiaEnum.Entregada,
                            Fecha = ahora
                        });

                        // Registrar en cuenta corriente cliente
                        int nuevoIdCliente = CtaCteClienteAlmacen.ctaCteClientes.Count + 1;
                        CtaCteClienteAlmacen.ctaCteClientes.Add(new CtaCteClienteEntidad
                        {
                            IdMovimientoCliente = nuevoIdCliente,
                            IdCliente = guiaEntidad.IdCliente,
                            IdGuia = guiaEntidad.IdGuia,
                            Facturado = false,
                            Importe = guiaEntidad.TarifaDefinitiva,
                            FechaMovimiento = ahora
                        });

                        // Registrar comision agencia origen si corresponde
                        if (guiaEntidad.IdComisionAgencia > 0 && guiaEntidad.IdAgenciaOrigen > 0)
                        {
                            decimal montoAgencia = 0;
                            foreach (ComisionAgenciaEntidad ca in ComisionAgenciaAlmacen.comisionAgencias)
                            {
                                if (ca.IdComisionAgencia == guiaEntidad.IdComisionAgencia)
                                {
                                    montoAgencia = ca.MontoComision;
                                    break;
                                }
                            }

                            int nuevoIdAgencia = CtaCteAgenciaAlmacen.ctaCteAgencias.Count + 1;
                            CtaCteAgenciaAlmacen.ctaCteAgencias.Add(new CtaCteAgenciaEntidad
                            {
                                IdMovimientoAgencia = nuevoIdAgencia,
                                IdAgencia = guiaEntidad.IdAgenciaOrigen,
                                IdGuia = guiaEntidad.IdGuia,
                                Pagado = false,
                                Importe = montoAgencia,
                                FechaMovimiento = ahora
                            });
                        }

                        break;
                    }
                }
            }

            return true;
        }

        internal void LimpiarSeleccion()
        {
            ReceptorSeleccionado = null;
            GuiasDisponibles = new List<GuiaEntrega>();
        }
    }
}