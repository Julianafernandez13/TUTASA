using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTASA.Almacenes;

namespace TUTASA.ConfeccionHDRdeUltMilla
{
    internal class ConfeccionHDRdeUltMillaModelo
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

        public List<Guia> GuiasEncontradas { get; set; } = new List<Guia>();
        public bool Limpiando { get; set; } = false;

        // Devuelve las localidades que tienen guías según el tipo de HDR
        public List<string> ObtenerLocalidadesPorTipo(string tipoHDR)
        {
            var localidades = new List<string>();

            foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
            {
                if (!EsGuiaParaTipoHDR(guiaEntidad, tipoHDR))
                    continue;

                string localidad = ObtenerLocalidadParaHDR(guiaEntidad, tipoHDR);
                if (localidad != null && !localidades.Contains(localidad))
                    localidades.Add(localidad);
            }

            return localidades;
        }

        // Devuelve los domicilios unicos de una localidad segun el tipo de HDR
        public List<string> ObtenerDomiciliosPorLocalidadYTipo(string localidad, string tipoHDR)
        {
            var domicilios = new List<string>();

            foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
            {
                if (!EsGuiaParaTipoHDR(guiaEntidad, tipoHDR))
                    continue;

                string localidadGuia = ObtenerLocalidadParaHDR(guiaEntidad, tipoHDR);
                if (localidadGuia != localidad)
                    continue;

                string domicilio = ObtenerDomicilioParaHDR(guiaEntidad, tipoHDR);
                if (domicilio != null && !domicilios.Contains(domicilio))
                    domicilios.Add(domicilio);
            }

            return domicilios;
        }

        // Devuelve las guias filtradas por localidad, domicilio y tipo de HDR
        public List<Guia> ObtenerGuiasPendientes(string localidad, string domicilio, string tipoHDR)
        {
            var resultado = new List<Guia>();

            foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
            {
                if (!EsGuiaParaTipoHDR(guiaEntidad, tipoHDR))
                    continue;

                string localidadGuia = ObtenerLocalidadParaHDR(guiaEntidad, tipoHDR);
                if (localidadGuia != localidad)
                    continue;

                string domicilioGuia = ObtenerDomicilioParaHDR(guiaEntidad, tipoHDR);
                if (domicilioGuia != domicilio)
                    continue;

                var guia = new Guia();
                guia.Id = guiaEntidad.IdGuia;
                guia.NroTracking = guiaEntidad.NroTracking;
                guia.NombreDestinatario = guiaEntidad.NombreApellidoDestinatario;
                guia.DomicilioEntrega = domicilioGuia;
                guia.Localidad = localidadGuia;
                guia.CodigoPostal = guiaEntidad.DomicilioEntregaCodPostal;
                guia.TarifaDefinitiva = guiaEntidad.TarifaDefinitiva;

                if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.S) guia.Categoria = "S";
                else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.M) guia.Categoria = "M";
                else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.L) guia.Categoria = "L";
                else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.XL) guia.Categoria = "XL";

                if (guiaEntidad.TipoEntrega == TipoEntregaEnum.Domicilio) guia.TipoEntrega = "Domicilio";
                else if (guiaEntidad.TipoEntrega == TipoEntregaEnum.Agencia) guia.TipoEntrega = "Agencia";
                else if (guiaEntidad.TipoEntrega == TipoEntregaEnum.CD) guia.TipoEntrega = "CD";

                if (guiaEntidad.EstadoGuia == EstadoGuiaEnum.DisponibleParaRetiro)
                    guia.EstadoActual = "DisponibleParaRetiro";
                else if (guiaEntidad.EstadoGuia == EstadoGuiaEnum.PendienteDeDistribucion)
                    guia.EstadoActual = "PendienteDeDistribucion";
                else if (guiaEntidad.EstadoGuia == EstadoGuiaEnum.IntentoDeEntregaFallido)
                    guia.EstadoActual = "IntentoDeEntregaFallido";

                // Agencia destino si corresponde
                if (guiaEntidad.IdAgenciaDestino > 0)
                {
                    foreach (AgenciaEntidad agencia in AgenciaAlmacen.agencias)
                    {
                        if (agencia.IdAgencia == guiaEntidad.IdAgenciaDestino)
                        {
                            guia.Agencia = agencia.NombreAgencia;
                            break;
                        }
                    }
                }

                resultado.Add(guia);
            }

            return resultado;
        }

        // Devuelve los fleteros disponibles en una localidad
        public List<Fletero> ObtenerFleterosPorLocalidad(string localidad)
        {
            var resultado = new List<Fletero>();

            foreach (FleteroEntidad fleteroEntidad in FleteroAlmacen.fleteros)
            {
                bool cubre = false;
                foreach (string codPostal in fleteroEntidad.IdCodPostal)
                {
                    string localidadCP = ObtenerLocalidad(codPostal);
                    if (localidadCP == localidad)
                    {
                        cubre = true;
                        break;
                    }
                }

                if (cubre)
                {
                    resultado.Add(new Fletero
                    {
                        Id = fleteroEntidad.IdFletero,
                        NombreCompleto = fleteroEntidad.NombreFletero + " " + fleteroEntidad.ApellidoFletero,
                        Localidad = localidad
                    });
                }
            }

            return resultado;
        }

        // Confirma la HDR y actualiza el almacen
        public void ConfirmarHDR(List<Guia> guiasSeleccionadas, Fletero fletero, string tipoHDR)
        {
            DateTime ahora = DateTime.Now;

            if (tipoHDR == "Retiro")
            {
                int nuevoId = HDRRetiroAlmacen.hDRRetiros.Count + 1;
                var nuevaHDR = new HDRRetiroEntidad
                {
                    IdHDRdeRetiro = nuevoId,
                    IdFletero = fletero.Id,
                    FechaEmisionHDR = ahora,
                    EstadoHDR = EstadoHDRUltimaMillaEnum.Pendiente,
                    GuiasRetiro = new List<int>()
                };

                foreach (var guia in guiasSeleccionadas)
                {
                    nuevaHDR.GuiasRetiro.Add(guia.Id);

                    foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
                    {
                        if (guiaEntidad.IdGuia == guia.Id)
                        {
                            guiaEntidad.EstadoGuia = EstadoGuiaEnum.IncluidaEnHDRRetiro;
                            guiaEntidad.Historial.Add(new HistorialGuia
                            {
                                Estado = EstadoGuiaEnum.IncluidaEnHDRRetiro,
                                Fecha = ahora
                            });
                            break;
                        }
                    }
                }

                HDRRetiroAlmacen.hDRRetiros.Add(nuevaHDR);
            }
            else if (tipoHDR == "Entrega")
            {
                int nuevoId = HDREntregaAlmacen.hDREntregas.Count + 1;
                var nuevaHDR = new HDREntregaEntidad
                {
                    IdHDRdeEntrega = nuevoId,
                    IdFletero = fletero.Id,
                    FechaEmisionHDR = ahora,
                    EstadoHDR = EstadoHDRUltimaMillaEnum.Pendiente,
                    GuiasEntrega = new List<int>()
                };

                foreach (var guia in guiasSeleccionadas)
                {
                    nuevaHDR.GuiasEntrega.Add(guia.Id);

                    foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
                    {
                        if (guiaEntidad.IdGuia == guia.Id)
                        {
                            guiaEntidad.EstadoGuia = EstadoGuiaEnum.IncluidaEnHDREntrega;
                            guiaEntidad.Historial.Add(new HistorialGuia
                            {
                                Estado = EstadoGuiaEnum.IncluidaEnHDREntrega,
                                Fecha = ahora
                            });
                            break;
                        }
                    }
                }

                HDREntregaAlmacen.hDREntregas.Add(nuevaHDR);

            }
        }

        // Verifica si una guia corresponde al tipo de HDR y al CD de sesion
        private bool EsGuiaParaTipoHDR(GuiaEntidad guiaEntidad, string tipoHDR)
        {
            if (tipoHDR == "Retiro")
            {
                return guiaEntidad.EstadoGuia == EstadoGuiaEnum.DisponibleParaRetiro
                    && guiaEntidad.IdCDOrigen == cdActivo.IdCD;
            }
            else if (tipoHDR == "Entrega")
            {
                return (guiaEntidad.EstadoGuia == EstadoGuiaEnum.PendienteDeDistribucion
                        || guiaEntidad.EstadoGuia == EstadoGuiaEnum.IntentoDeEntregaFallido)
                    && guiaEntidad.IdCDDestino == cdActivo.IdCD
                    && guiaEntidad.TipoEntrega != TipoEntregaEnum.CD;
            }
            return false;
        }

        // Obtiene la localidad segun el tipo de HDR
        private string ObtenerLocalidadParaHDR(GuiaEntidad guiaEntidad, string tipoHDR)
        {
            if (tipoHDR == "Retiro")
                return ObtenerLocalidadPorAgencia(guiaEntidad.IdAgenciaOrigen);
            else
            {
                if (guiaEntidad.TipoEntrega == TipoEntregaEnum.Agencia)
                    return ObtenerLocalidadPorAgencia(guiaEntidad.IdAgenciaDestino);
                else
                    return ObtenerLocalidad(guiaEntidad.DomicilioEntregaCodPostal);
            }
        }

        private string ObtenerDomicilioParaHDR(GuiaEntidad guiaEntidad, string tipoHDR)
        {
            if (tipoHDR == "Retiro")
                return ObtenerDomicilioPorAgencia(guiaEntidad.IdAgenciaOrigen);
            else
            {
                if (guiaEntidad.TipoEntrega == TipoEntregaEnum.Agencia)
                    return ObtenerDomicilioPorAgencia(guiaEntidad.IdAgenciaDestino);
                else
                    return guiaEntidad.DomicilioEntrega;
            }
        }

        // Obtiene la localidad a partir de un codigo postal
        private string ObtenerLocalidad(string codPostal)
        {
            foreach (CodigoPostalEntidad cp in CodigoPostalAlmacen.codigoPostals)
            {
                if (cp.IdCodPostal == codPostal)
                    return cp.DescripcionLocalidad;
            }
            return null;
        }

        // Obtiene la localidad a partir de una agencia
        private string ObtenerLocalidadPorAgencia(int idAgencia)
        {
            foreach (AgenciaEntidad agencia in AgenciaAlmacen.agencias)
            {
                if (agencia.IdAgencia == idAgencia)
                    return ObtenerLocalidad(agencia.IdCodPostal);
            }
            return null;
        }

        // Obtiene el domicilio a partir de una agencia
        private string ObtenerDomicilioPorAgencia(int idAgencia)
        {
            foreach (AgenciaEntidad agencia in AgenciaAlmacen.agencias)
            {
                if (agencia.IdAgencia == idAgencia)
                    return agencia.DomicilioAgencia;
            }
            return null;
        }
    }
}
