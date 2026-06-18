using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUTASA.Almacenes;

namespace TUTASA.RendicionHDRdeTransporte
{
    internal class RendicionHDRTransporteModelo
    {
        public List<EmpresaTransporte> EmpresasActuales { get; private set; } = new List<EmpresaTransporte>();
        public List<HDR> HDRsActuales { get; private set; } = new List<HDR>();
        public HDR HdrActual { get; set; } = null;
        public bool Limpiando { get; set; } = false;

        // CD activo de sesion (hardcodeado por ahora)
        private int idCDSesion = 1; // CD bs as

        // Devuelve todas las empresas de transporte
        public void ObtenerEmpresas()
        {
            EmpresasActuales = new List<EmpresaTransporte>();
            foreach (EmpresaTransporteEntidad emp in EmpresaTransporteAlmacen.empresaTransportes)
            {
                EmpresasActuales.Add(new EmpresaTransporte
                {
                    Id = emp.IdEmpresaTransporte,
                    Nombre = emp.NombreEmpresa
                });
            }
        }

        // Devuelve las HDRs en estado Despachada para una empresa cuyo CDDestino es el CD de sesion
        public void ObtenerHDRsPorEmpresa(int idEmpresa)
        {
            HDRsActuales = new List<HDR>();
            
            foreach (HDRTransporteEntidad hdrEntidad in HDRTransporteAlmacen.hDRTransportes)
            {
                
                if (hdrEntidad.IdEmpresaTransporte != idEmpresa) continue;
                if (hdrEntidad.EstadoHDR != EstadoHDRTransporteEnum.Despachada) continue;
                if (hdrEntidad.IdCDDestino != idCDSesion) continue;

                // Buscar nombre CD origen
                string nombreCDOrigen = "";
                string nombreCDDestino = "";
                foreach (CentroDistribucionEntidad cd in CentroDistribucionAlmacen.centroDistribucions)
                {
                    if (cd.IdCD == hdrEntidad.IdCDOrigen) nombreCDOrigen = cd.NombreCD;
                    if (cd.IdCD == hdrEntidad.IdCDDestino) nombreCDDestino = cd.NombreCD;
                }

                // Mapear guias
                var guias = new List<Guia>();
                foreach (int idGuia in hdrEntidad.GuiasDespachadas)
                {
                    foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
                    {
                        if (guiaEntidad.IdGuia == idGuia)
                        {
                            var guia = new Guia();
                            guia.Id = guiaEntidad.IdGuia;
                            guia.NroTracking = guiaEntidad.NroTracking;
                            guia.NombreDestinatario = guiaEntidad.NombreApellidoDestinatario;

                            if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.S) guia.Categoria = "S";
                            else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.M) guia.Categoria = "M";
                            else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.L) guia.Categoria = "L";
                            else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.XL) guia.Categoria = "XL";

                            // Buscar nombre remitente
                            foreach (ClienteEntidad clienteEntidad in ClienteAlmacen.clientes)
                            {
                                if (clienteEntidad.IdCliente == guiaEntidad.IdCliente)
                                {
                                    guia.NombreRemitente = clienteEntidad.NombreCliente + " " + clienteEntidad.ApellidoCliente;
                                    break;
                                }
                            }

                            guias.Add(guia);
                            break;
                        }
                    }
                }

                HDRsActuales.Add(new HDR
                {
                    Id = (int)hdrEntidad.IdHDRdeTransporte,
                    NroHDR = "TRP-" + hdrEntidad.IdHDRdeTransporte.ToString("D6"),
                    CdOrigen = nombreCDOrigen,
                    CdDestino = nombreCDDestino,
                    CantBultos = guias.Count,
                    EstadoActual = "Despachada",
                    IdEmpresaTransporte = hdrEntidad.IdEmpresaTransporte,
                    Guias = guias
                });
            }
        }

        // Confirma la recepcion de una HDR
        public void ConfirmarRecepcion(HDR hdr)
        {
            DateTime ahora = DateTime.Now;

            foreach (HDRTransporteEntidad hdrEntidad in HDRTransporteAlmacen.hDRTransportes)
            {
                if ((int)hdrEntidad.IdHDRdeTransporte == hdr.Id)
                {
                    hdrEntidad.EstadoHDR = EstadoHDRTransporteEnum.Recepcionada;
                    break;
                }
            }

            // Actualizar estado de las guias
            foreach (var guia in hdr.Guias)
            {
                foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
                {
                    if (guiaEntidad.IdGuia == guia.Id)
                    {
                        EstadoGuiaEnum nuevoEstado;

                        if (guiaEntidad.IdCDDestino == idCDSesion)
                        {
                            if (guiaEntidad.TipoEntrega == TipoEntregaEnum.CD)
                                nuevoEstado = EstadoGuiaEnum.DisponibleParaEntrega;
                            else
                                nuevoEstado = EstadoGuiaEnum.PendienteDeDistribucion;
                        }
                        else
                        {
                            nuevoEstado = EstadoGuiaEnum.Admitida;
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
            HDRTransporteAlmacen.Guardar();
            GuiaAlmacen.Guardar();
        }
    }
}
