using System;
using System.Collections.Generic;
using System.Drawing;
using TUTASA.Almacenes;

namespace TUTASA.ConsultaTracking
{
    internal class ConsultaTrackingModelo
    {
        public GuiaTracking GuiaSeleccionada { get; private set; }

        internal bool BuscarGuia(string nroTracking)
        {
            GuiaSeleccionada = null;

            foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
            {
                if (guiaEntidad.NroTracking == nroTracking.Trim().ToUpper())
                {
                    GuiaSeleccionada = MapearGuia(guiaEntidad);
                    break;
                }
            }

            if (GuiaSeleccionada == null)
            {
                System.Windows.Forms.MessageBox.Show(
                    "La guía ingresada no corresponde a ninguna solicitud registrada.",
                    "Guía no encontrada",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private GuiaTracking MapearGuia(GuiaEntidad guiaEntidad)
        {
            var guia = new GuiaTracking();
            guia.Id = guiaEntidad.IdGuia;
            guia.NroTracking = guiaEntidad.NroTracking;

            // Estado actual
            guia.EstadoActual = ObtenerDescripcionEstado(guiaEntidad.EstadoGuia);

            // Categoria
            if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.S) guia.Categoria = "S";
            else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.M) guia.Categoria = "M";
            else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.L) guia.Categoria = "L";
            else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.XL) guia.Categoria = "XL";

            // CD Origen
            foreach (CentroDistribucionEntidad cd in CentroDistribucionAlmacen.centroDistribucions)
            {
                if (cd.IdCD == guiaEntidad.IdCDOrigen)
                {
                    guia.CdOrigen = cd.NombreCD;
                    break;
                }
            }

            // CD Destino
            foreach (CentroDistribucionEntidad cd in CentroDistribucionAlmacen.centroDistribucions)
            {
                if (cd.IdCD == guiaEntidad.IdCDDestino)
                {
                    guia.CdDestino = cd.NombreCD;
                    break;
                }
            }

            // Nombre cliente (remitente)
            foreach (ClienteEntidad clienteEntidad in ClienteAlmacen.clientes)
            {
                if (clienteEntidad.IdCliente == guiaEntidad.IdCliente)
                {
                    guia.NombreRemitente = clienteEntidad.NombreCliente + " " + clienteEntidad.ApellidoCliente;
                    break;
                }
            }

            guia.NombreDestinatario = guiaEntidad.NombreApellidoDestinatario;
            guia.Historial = guiaEntidad.Historial;

            return guia;
        }

        public List<EventoHistorial> ObtenerHistorial(GuiaTracking guia)
        {
            var resultado = new List<EventoHistorial>();

            foreach (HistorialGuia h in guia.Historial)
            {
                resultado.Add(new EventoHistorial
                {
                    Fecha = h.Fecha.ToString("dd/MM/yyyy"),
                    Hora = h.Fecha.ToString("HH:mm"),
                    Ubicacion = guia.CdOrigen,
                    Estado = ObtenerDescripcionEstado(h.Estado)
                });
            }

            return resultado;
        }

        public Color ObtenerColorEstado(string estado)
        {
            if (estado.Contains("Entregada")) return Color.LimeGreen;
            if (estado.Contains("Cancelada")) return Color.Red;
            if (estado.Contains("Disponible")) return Color.LightBlue;
            if (estado.Contains("Admitida")) return Color.LightGreen;
            if (estado.Contains("Pendiente")) return Color.Orange;
            if (estado.Contains("Impuesta")) return Color.LightYellow;
            return Color.White;
        }

        private string ObtenerDescripcionEstado(EstadoGuiaEnum estado)
        {
            switch (estado)
            {
                case EstadoGuiaEnum.Impuesta:                   return "Impuesta";
                case EstadoGuiaEnum.DisponibleParaRetiro:       return "Disponible para retiro en agencia o domicilio";
                case EstadoGuiaEnum.IncluidaEnHDRRetiro:        return "Esperando Fletero";
                case EstadoGuiaEnum.PreAdmitida:                return "Pre-admitida en CD";
                case EstadoGuiaEnum.Admitida:                   return "Admitida en CD";
                case EstadoGuiaEnum.IncluidaEnHDRTransporte:    return "Esperando Transporte";
                case EstadoGuiaEnum.PendienteDeDistribucion:    return "Pendiente de distribución";
                case EstadoGuiaEnum.IncluidaEnHDREntrega:       return "Esperando Fletero";
                case EstadoGuiaEnum.IntentoDeEntregaFallido:    return "Intento de entrega fallido";
                case EstadoGuiaEnum.DisponibleParaEntrega:      return "Disponible para entregar en destino";
                case EstadoGuiaEnum.Cancelada:                  return "Cancelada - Dos intentos de entrega fallidos";
                case EstadoGuiaEnum.Entregada:                  return "Entregada";
                default:                                        return estado.ToString();
            }
        }

        internal void LimpiarSeleccion()
        {
            GuiaSeleccionada = null;
        }
    }
}