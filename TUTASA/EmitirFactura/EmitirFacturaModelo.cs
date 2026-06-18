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
        public Cliente ClienteActual { get; private set; }
        public List<MovimientoPendiente> MovimientosActuales { get; private set; } = new List<MovimientoPendiente>();

        // Busca un cliente por CUIT en el almacen
        public bool BuscarClientePorCUIT(string cuit)
        {
            ClienteActual = null;

            foreach (ClienteEntidad clienteEntidad in ClienteAlmacen.clientes)
            {
                if (clienteEntidad.CuitCliente.ToString() == cuit.Trim())
                {
                    ClienteActual = new Cliente
                    {
                        Id = clienteEntidad.IdCliente,
                        NombreCompleto = clienteEntidad.NombreCliente + " " + clienteEntidad.ApellidoCliente,
                        CUIT = clienteEntidad.CuitCliente.ToString(),
                        TipoFactura = clienteEntidad.TipoFactura
                    };
                    return true;
                }
            }
            return false;
        }

        // Obtiene los movimientos pendientes de facturacion del cliente actual en un periodo
        public void ObtenerMovimientosPendientes(int mes, int anio)
        {
            MovimientosActuales = new List<MovimientoPendiente>();

            foreach (CtaCteClienteEntidad movEntidad in CtaCteClienteAlmacen.ctaCteClientes)
            {
                if (movEntidad.IdCliente != ClienteActual.Id) continue;
                if (movEntidad.Facturado) continue;
                if (movEntidad.FechaMovimiento.Month != mes) continue;
                if (movEntidad.FechaMovimiento.Year != anio) continue;

                var mov = new MovimientoPendiente();
                mov.IdMovimiento = movEntidad.IdMovimientoCliente;
                mov.IdCliente = movEntidad.IdCliente;
                mov.Fecha = movEntidad.FechaMovimiento;
                mov.ImporteNeto = movEntidad.Importe;
                mov.Facturado = movEntidad.Facturado;

                foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
                {
                    if (guiaEntidad.IdGuia == movEntidad.IdGuia)
                    {
                        mov.NroGuia = guiaEntidad.NroTracking;

                        if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.S) mov.Categoria = "S";
                        else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.M) mov.Categoria = "M";
                        else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.L) mov.Categoria = "L";
                        else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.XL) mov.Categoria = "XL";

                        foreach (CentroDistribucionEntidad cd in CentroDistribucionAlmacen.centroDistribucions)
                        {
                            if (cd.IdCD == guiaEntidad.IdCDOrigen)
                            {
                                mov.Origen = cd.NombreCD;
                                break;
                            }
                        }

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

                MovimientosActuales.Add(mov);
            }
        }

        // Calcula el total con IVA segun el tipo de factura del cliente
        public decimal CalcularTotal(List<MovimientoPendiente> movs, TipoFacturaEnum tipoFactura)
        {
            decimal subtotal = 0;
            foreach (var m in movs)
                subtotal += m.ImporteNeto;

            return tipoFactura == TipoFacturaEnum.A ? subtotal * 1.21m : subtotal;
        }

        // Emite la factura y marca los movimientos como facturados
        public void EmitirFactura()
        {
            DateTime ahora = DateTime.Now;
            decimal importeTotal = CalcularTotal(MovimientosActuales, ClienteActual.TipoFactura);
            var idsMovs = new List<int>();

            foreach (var mov in MovimientosActuales)
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

            FacturaAlmacen.facturas.Add(new FacturaEntidad
            {
                IdFactura = FacturaAlmacen.facturas.Count + 1,
                IdCliente = ClienteActual.Id,
                FechaEmision = ahora,
                CAE = 0,
                TipoFactura = ClienteActual.TipoFactura,
                Movimientos = idsMovs
            });

            FacturaAlmacen.Guardar();
            CtaCteClienteAlmacen.Guardar();

            // Limpiar estado
            ClienteActual = null;
            MovimientosActuales = new List<MovimientoPendiente>();
        }
    }
}
