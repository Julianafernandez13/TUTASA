using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTASA.Almacenes;

namespace TUTASA.EmitirFactura
{
    internal class EmitirFacturaModelo
    {
        // Busca un cliente por CUIT en el almacen
        public Cliente BuscarClientePorCUIT(string cuit)
        {
            foreach (ClienteEntidad clienteEntidad in ClienteAlmacen.clientes)
            {
                if (clienteEntidad.CuitCliente.ToString() == cuit.Trim())
                {
                    return new Cliente
                    {
                        Id = clienteEntidad.IdCliente,
                        NombreCompleto = clienteEntidad.NombreCliente + " " + clienteEntidad.ApellidoCliente,
                        CUIT = clienteEntidad.CuitCliente.ToString(),
                        TipoFactura = clienteEntidad.TipoFactura
                    };
                }
            }
            return null;
        }

        // Devuelve los movimientos pendientes de facturacion de un cliente en un periodo
        public List<MovimientoPendiente> ObtenerMovimientosPendientes(int idCliente, int mes, int anio)
        {
            var resultado = new List<MovimientoPendiente>();

            foreach (CtaCteClienteEntidad movEntidad in CtaCteClienteAlmacen.ctaCteClientes)
            {
                if (movEntidad.IdCliente != idCliente) continue;
                if (movEntidad.Facturado) continue;
                if (movEntidad.FechaMovimiento.Month != mes) continue;
                if (movEntidad.FechaMovimiento.Year != anio) continue;

                var mov = new MovimientoPendiente();
                mov.IdMovimiento = movEntidad.IdMovimientoCliente;
                mov.IdCliente = movEntidad.IdCliente;
                mov.Fecha = movEntidad.FechaMovimiento;
                mov.ImporteNeto = movEntidad.Importe;
                mov.Facturado = movEntidad.Facturado;

                // Buscar guia para obtener NroTracking, origen y destino
                foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
                {
                    if (guiaEntidad.IdGuia == movEntidad.IdGuia)
                    {
                        mov.NroGuia = guiaEntidad.NroTracking;

                        if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.S) mov.Categoria = "S";
                        else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.M) mov.Categoria = "M";
                        else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.L) mov.Categoria = "L";
                        else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.XL) mov.Categoria = "XL";

                        // Buscar nombre CD origen
                        foreach (CentroDistribucionEntidad cd in CentroDistribucionAlmacen.centroDistribucions)
                        {
                            if (cd.IdCD == guiaEntidad.IdCDOrigen)
                            {
                                mov.Origen = cd.NombreCD;
                                break;
                            }
                        }

                        // Buscar nombre CD destino
                        foreach (CentroDistribucionEntidad cd in CentroDistribucionAlmacen.centroDistribucions)
                        {
                            if (cd.IdCD == guiaEntidad.IdCDDestino)
                            {
                                mov.Destino = cd.NombreCD;
                                break;
                            }
                        }

                        break;
                    }
                }

                resultado.Add(mov);
            }

            return resultado;
        }

        // Calcula el total con IVA segun la condicion fiscal del cliente
        public decimal CalcularTotal(List<MovimientoPendiente> movs, TipoFacturaEnum tipoFactura)
        {
            decimal subtotal = 0;
            foreach (var m in movs)
                subtotal += m.ImporteNeto;

            return tipoFactura == TipoFacturaEnum.A ? subtotal * 1.21m : subtotal;
        }

        // Emite la factura: marca movimientos como facturados y crea el registro en FacturaAlmacen
        public void EmitirFactura(List<MovimientoPendiente> movs, int idCliente, TipoFacturaEnum tipoFactura)
        {
            DateTime ahora = DateTime.Now;
            decimal importeTotal = CalcularTotal(movs, tipoFactura);
            var idsMovs = new List<int>();

            // Marcar movimientos como facturados
            foreach (var mov in movs)
            {
                foreach (CtaCteClienteEntidad movEntidad in CtaCteClienteAlmacen.ctaCteClientes)
                {
                    if (movEntidad.IdMovimientoCliente == mov.IdMovimiento)
                    {
                        movEntidad.Facturado = true;
                        idsMovs.Add(movEntidad.IdMovimientoCliente);
                        break;
                    }
                }
            }

            // Crear factura en almacen
            FacturaAlmacen.facturas.Add(new FacturaEntidad
            {
                IdFactura = FacturaAlmacen.facturas.Count + 1,
                IdCliente = idCliente,
                FechaEmision = ahora,
                CAE = 0, // se completara con integracion AFIP
                TipoFactura = tipoFactura,
                Movimientos = idsMovs
            });

            FacturaAlmacen.Guardar();
            CtaCteClienteAlmacen.Guardar();
        }
    }
}
