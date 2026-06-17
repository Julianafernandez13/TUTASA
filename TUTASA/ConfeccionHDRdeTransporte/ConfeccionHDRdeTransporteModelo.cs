using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTASA.Almacenes;

namespace TUTASA.ConfeccionHDRdeTransporte
{
    internal class ConfeccionHDRdeTransporteModelo
    {
        public List<Guia> GuiasSeleccionadas { get; set; } = new List<Guia>();
        public bool Limpiando { get; set; } = false;
        public int IdCDOrigen { get; set; } = 1; // CD Buenos Aires

        // Devuelve los CDs destino que tienen guias admitidas desde el CD de sesion
        public List<CentroDistribucionEntidad> ObtenerDestinosDisponibles()
        {
            var idsDestino = new List<int>();
            foreach (var ruta in RutasEmpresaTransporteAlmacen.rutasEmpresaTransportes)
            {
                if (ruta.IdCDOrigen == IdCDOrigen && !idsDestino.Contains(ruta.IdCDDestino))
                    idsDestino.Add(ruta.IdCDDestino);
            }

            var resultado = new List<CentroDistribucionEntidad>();
            foreach (var cd in CentroDistribucionAlmacen.centroDistribucions)
            {
                if (idsDestino.Contains(cd.IdCD))
                    resultado.Add(cd);
            }
            return resultado;
        }

        // Devuelve las empresas que cubren el tramo origen → destino
        public List<EmpresaTransporte> ObtenerEmpresasPorTramo(int idCDDestino)
        {
            var idsEmpresa = new List<int>();
            foreach (var ruta in RutasEmpresaTransporteAlmacen.rutasEmpresaTransportes)
            {
                if (ruta.IdCDOrigen == IdCDOrigen && ruta.IdCDDestino == idCDDestino)
                    idsEmpresa.Add(ruta.IdEmpresaTransporte);
            }

            var resultado = new List<EmpresaTransporte>();
            foreach (var emp in EmpresaTransporteAlmacen.empresaTransportes)
            {
                if (idsEmpresa.Contains(emp.IdEmpresaTransporte))
                {
                    resultado.Add(new EmpresaTransporte
                    {
                        IdEmpresaTransporte = emp.IdEmpresaTransporte,
                        NombreEmpresa = emp.NombreEmpresa,
                        TipoArrendamiento = emp.TipoArrendamiento
                    });
                }
            }
            return resultado;
        }

        // Devuelve las guias admitidas para un CD destino desde GuiaAlmacen
        public List<Guia> ObtenerGuiasPorCDDestino(int idCDDestino)
        {
            var resultado = new List<Guia>();

            foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
            {
                if (guiaEntidad.EstadoGuia != EstadoGuiaEnum.Admitida)
                    continue;
                if (guiaEntidad.IdCDOrigen != IdCDOrigen)
                    continue;
                if (guiaEntidad.IdCDDestino != idCDDestino)
                    continue;

                var guia = new Guia();
                guia.Id = guiaEntidad.IdGuia;
                guia.NroTracking = guiaEntidad.NroTracking;

                if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.S) guia.Categoria = "S";
                else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.M) guia.Categoria = "M";
                else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.L) guia.Categoria = "L";
                else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.XL) guia.Categoria = "XL";

                // Buscar nombre del CD destino
                foreach (CentroDistribucionEntidad cd in CentroDistribucionAlmacen.centroDistribucions)
                {
                    if (cd.IdCD == guiaEntidad.IdCDDestino)
                    {
                        guia.CdDestino = cd.NombreCD;
                        break;
                    }
                }

                resultado.Add(guia);
            }

            return resultado;
        }

        // Devuelve el limite en XL equivalente segun el tipo de arrendamiento
        public decimal ObtenerLimiteXL(TipoArrendamientoEnum tipo)
        {
            switch (tipo)
            {
                case TipoArrendamientoEnum.D: return 3m;
                case TipoArrendamientoEnum.C: return 7m;
                case TipoArrendamientoEnum.B: return 10m;
                case TipoArrendamientoEnum.A: return 20m;
                default: return 0m;
            }
        }

        // Calcula la equivalencia en XL de una lista de guias
        public decimal CalcularEquivalenciaXL(List<Guia> guiasACalcular)
        {
            decimal totalXL = 0;
            foreach (var g in guiasACalcular)
            {
                switch (g.Categoria)
                {
                    case "S": totalXL += 0.125m; break;
                    case "M": totalXL += 0.25m; break;
                    case "L": totalXL += 0.5m; break;
                    case "XL": totalXL += 1m; break;
                }
            }
            return totalXL;
        }

        // Verifica si agregar una guia supera el limite del tipo de arrendamiento
        public bool SuperaLimite(Guia guiaAAgregar, TipoArrendamientoEnum tipoArrendamiento)
        {
            decimal equivalenciaNueva = 0;
            switch (guiaAAgregar.Categoria)
            {
                case "S": equivalenciaNueva = 0.125m; break;
                case "M": equivalenciaNueva = 0.25m; break;
                case "L": equivalenciaNueva = 0.5m; break;
                case "XL": equivalenciaNueva = 1m; break;
            }

            decimal totalActual = CalcularEquivalenciaXL(GuiasSeleccionadas);
            decimal limite = ObtenerLimiteXL(tipoArrendamiento);

            return (totalActual + equivalenciaNueva) > limite;
        }

        // Guarda la HDR de transporte y actualiza el estado de las guias
        public void GuardarHDR(EmpresaTransporte empresa, int idCDDestino)
        {
            DateTime ahora = DateTime.Now;
            var idsGuias = new List<int>();

            foreach (var g in GuiasSeleccionadas)
                idsGuias.Add(g.Id);

            // Crear HDR en almacen
            HDRTransporteAlmacen.hDRTransportes.Add(new HDRTransporteEntidad
            {
                IdHDRdeTransporte = HDRTransporteAlmacen.hDRTransportes.Count + 1,
                IdCDOrigen = IdCDOrigen,
                IdCDDestino = idCDDestino,
                IdEmpresaTransporte = empresa.IdEmpresaTransporte,
                Fecha = ahora,
                EstadoHDR = EstadoHDRTransporteEnum.Pendiente,
                DetalleDiscrepancias = string.Empty,
                GuiasDespachadas = idsGuias
            });

            // Actualizar estado de las guias en almacen
            foreach (var g in GuiasSeleccionadas)
            {
                foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
                {
                    if (guiaEntidad.IdGuia == g.Id)
                    {
                        guiaEntidad.EstadoGuia = EstadoGuiaEnum.IncluidaEnHDRTransporte;
                        guiaEntidad.Historial.Add(new HistorialGuia
                        {
                            Estado = EstadoGuiaEnum.IncluidaEnHDRTransporte,
                            Fecha = ahora
                        });
                        break;
                    }
                }
            }

            GuiasSeleccionadas.Clear();
            HDRTransporteAlmacen.Guardar();
            GuiaAlmacen.Guardar();
        }
    }
}