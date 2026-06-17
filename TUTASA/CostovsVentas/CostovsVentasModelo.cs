using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTASA.Almacenes;

namespace TUTASA.CostovsVentas
{
    internal class CostovsVentasModelo
    {
        // Devuelve la lista de nombres de empresas de transporte
        public List<string> ObtenerEmpresas()
        {
            var lista = new List<string>();
            foreach (EmpresaTransporteEntidad emp in EmpresaTransporteAlmacen.empresaTransportes)
                lista.Add(emp.NombreEmpresa);
            return lista;
        }

        // Genera el reporte de costos vs ventas por empresa en un periodo
        public List<ResultadoEmpresa> GenerarReporte(int mes, int anio, string empresaSeleccionada)
        {
            var resultados = new List<ResultadoEmpresa>();

            foreach (EmpresaTransporteEntidad emp in EmpresaTransporteAlmacen.empresaTransportes)
            {
                if (empresaSeleccionada != "Todas" && emp.NombreEmpresa != empresaSeleccionada)
                    continue;

                decimal costos = 0;
                decimal ingresos = 0;


                // Recorrer HDRs de transporte de esta empresa en el periodo
                foreach (HDRTransporteEntidad hdr in HDRTransporteAlmacen.hDRTransportes)
                {
                    if (hdr.IdEmpresaTransporte != emp.IdEmpresaTransporte) continue;
                    if (hdr.Fecha.Month != mes || hdr.Fecha.Year != anio) continue;

                    // Costo: tarifa de arrendamiento vigente en la fecha de la HDR
                    decimal tarifaArrendamiento = ObtenerTarifaArrendamiento(emp.TipoArrendamiento, hdr.Fecha);
                    costos += tarifaArrendamiento;

                    // Ingresos: suma de TarifaDefinitiva de las guias de esta HDR
                    foreach (int idGuia in hdr.GuiasDespachadas)
                    {
                        foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
                        {
                            if (guiaEntidad.IdGuia == idGuia)
                            {
                                ingresos += guiaEntidad.TarifaDefinitiva;
                                break;
                            }
                        }
                    }
                }

                // Solo agregar si tiene actividad en el periodo
                if (costos > 0 || ingresos > 0)
                {
                    resultados.Add(new ResultadoEmpresa
                    {
                        Empresa = emp.NombreEmpresa,
                        Clasificacion = emp.TipoArrendamiento.ToString(),
                        Ingresos = ingresos,
                        Costos = costos
                    });
                }
            }

            return resultados;
        }

        // Busca la tarifa de arrendamiento vigente mas reciente para un tipo dado
        private decimal ObtenerTarifaArrendamiento(TipoArrendamientoEnum tipo, DateTime fechaHDR)
        {
            decimal monto = 0;
            DateTime fechaVigente = DateTime.MinValue;

            foreach (TarifaArrendamientoEntidad tarifa in TarifaArrendamientoAlmacen.tarifaArrendamientos)
            {
                if (tarifa.TipoArrendamiento == tipo && tarifa.FechaVigencia <= fechaHDR)
                {
                    if (tarifa.FechaVigencia > fechaVigente)
                    {
                        fechaVigente = tarifa.FechaVigencia;
                        monto = tarifa.MontoArrendamiento;
                    }
                }
            }

            return monto;
        }
    }

}

