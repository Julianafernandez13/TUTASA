using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TUTASA.Almacenes;

namespace TUTASA.Admision
{
    internal class AdmisionModelo
    {
        public Guia GuiaSeleccionada { get; private set; }

        // CD activo de sesión (hardcodeado por ahora)
        private int idCDSesion = 1; // CD Buenos Aires

        // Filtra dinamicamente desde el almacen las guias en estado PreAdmitida
        private List<Guia> guias
        {
            get
            {
                var guiasAAdmitir = new List<Guia>();
                foreach (var guiaEntidad in GuiaAlmacen.guias)
                {
                    if (guiaEntidad.EstadoGuia == EstadoGuiaEnum.PreAdmitida) 
                    {
                        var guia = new Guia();
                        guia.IdGuia = guiaEntidad.IdGuia;
                        guia.NroTracking = guiaEntidad.NroTracking;
                                               
                        if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.S)
                            guia.Categoria = "S";
                        else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.M)
                            guia.Categoria = "M";
                        else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.L)
                            guia.Categoria = "L";
                        else if (guiaEntidad.CategoriaBulto == CategoriaBultoEnum.XL)
                            guia.Categoria = "XL";

                        guia.EstadoActual = "PreAdmitida";

                        guiasAAdmitir.Add(guia);
                    }
                }
                return guiasAAdmitir;
            }
        }

        public List<Categoria> Categorias
        {
            get
            {
                var lista = new List<Categoria>();
                foreach (CategoriaBultoEnum categoria in Enum.GetValues(typeof(CategoriaBultoEnum)))
                {
                    lista.Add(new Categoria
                    {
                        Id = (int)categoria + 1,
                        Descripcion = categoria.ToString()
                    });
                }
                return lista;
            }
        }

        internal bool BuscarGuia(string nroTracking)
        {
            GuiaSeleccionada = null;

            foreach (var guia in guias)
            {
                if (guia.NroTracking == nroTracking.Trim().ToUpper())
                {
                    GuiaSeleccionada = guia;
                    break;
                }
            }

            if (GuiaSeleccionada == null)
            {
                MessageBox.Show(
                    "La guía ingresada no corresponde a ninguna solicitud registrada o no está en estado PreAdmitida.",
                    "Guía no encontrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Calcula la tarifa definitiva para una guia
        internal decimal CalcularTarifaDefinitiva(string categoriaVerificada, GuiaEntidad guiaEntidad)
        {
            // Convertir string a enum
            CategoriaBultoEnum categoriaEnum = CategoriaBultoEnum.S;
            if (categoriaVerificada == "M") categoriaEnum = CategoriaBultoEnum.M;
            else if (categoriaVerificada == "L") categoriaEnum = CategoriaBultoEnum.L;
            else if (categoriaVerificada == "XL") categoriaEnum = CategoriaBultoEnum.XL;

            // 1) Buscar tarifa base vigente mas reciente
            TarifaCliente tarifaVigente = null;
            foreach (TarifaClienteEntidad t in TarifaClienteAlmacen.tarifaClientes)
            {
                if (t.CategoriaBulto == categoriaEnum
                    && t.IdCDOrigen == guiaEntidad.IdCDOrigen
                    && t.IdCDDestino == guiaEntidad.IdCDDestino
                    && t.FechaVigencia <= DateTime.Now)
                {
                    if (tarifaVigente == null || t.FechaVigencia > tarifaVigente.FechaVigencia)
                    {
                        tarifaVigente = new TarifaCliente
                        {
                            IdTarifaCliente = t.IdTarifaCliente,
                            IdCDOrigen = t.IdCDOrigen,
                            IdCDDestino = t.IdCDDestino,
                            PrecioBase = t.PrecioBase,
                            FechaVigencia = t.FechaVigencia
                        };
                    }
                }
            }

            decimal tarifa = tarifaVigente != null ? tarifaVigente.PrecioBase : 0;

            // 2) Buscar extras vigentes mas recientes
            Extras extrasVigentes = null;
            foreach (ExtrasEntidad e in ExtrasAlmacen.extrass)
            {
                if (e.FechaVigencia <= DateTime.Now)
                {
                    if (extrasVigentes == null || e.FechaVigencia > extrasVigentes.FechaVigencia)
                    {
                        extrasVigentes = new Extras
                        {
                            IdExtras = e.IdExtras,
                            ExtraRetiroDomicilio = e.ExtraRetiroDomicilio,
                            ExtraEntregaAgencia = e.ExtraEntregaAgencia,
                            ExtraEntregaDomicilio = e.ExtraEntregaDomicilio,
                            FechaVigencia = e.FechaVigencia
                        };
                    }
                }
            }

            // 3) Sumar extras segun los booleanos que vienen de la guia
            if (extrasVigentes != null)
            {
                if (guiaEntidad.TieneExtraRetiro)
                    tarifa += extrasVigentes.ExtraRetiroDomicilio;
                if (guiaEntidad.TieneExtraEntregaDomicilio)
                    tarifa += extrasVigentes.ExtraEntregaDomicilio;
                if (guiaEntidad.TieneExtraEntregaAgencia)
                    tarifa += extrasVigentes.ExtraEntregaAgencia;
            }

            return tarifa;
        }

        internal bool Admitir(Categoria categoriaVerificada)
        {
            if (GuiaSeleccionada == null)
            {
                MessageBox.Show(
                    "Debe buscar una guía primero.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (categoriaVerificada == null)
            {
                MessageBox.Show(
                    "Debe seleccionar una categoría.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            // Verificar si la categoria verificada difiere de la declarada
            if (GuiaSeleccionada.Categoria != categoriaVerificada.Descripcion)
            {
                var resultado = MessageBox.Show(
                    $"La guía tiene la categoría \"{GuiaSeleccionada.Categoria}\" declarada.\n¿Desea cambiarla a \"{categoriaVerificada.Descripcion}\" según verificación física?",
                    "Confirmar cambio de categoría",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                    return false;
            }

            // Buscar GuiaEntidad en el almacen
            GuiaEntidad guiaEntidad = null;
            foreach (GuiaEntidad g in GuiaAlmacen.guias)
            {
                if (g.IdGuia == GuiaSeleccionada.IdGuia)
                {
                    guiaEntidad = g;
                    break;
                }
            }

            if (guiaEntidad == null)
                return false;

            // Calcular tarifa definitiva con la categoria verificada
            decimal tarifaDefinitiva = CalcularTarifaDefinitiva(categoriaVerificada.Descripcion, guiaEntidad);

            // Convertir categoria verificada a enum para guardar en almacen
            CategoriaBultoEnum categoriaEnum = CategoriaBultoEnum.S;
            if (categoriaVerificada.Descripcion == "M") categoriaEnum = CategoriaBultoEnum.M;
            else if (categoriaVerificada.Descripcion == "L") categoriaEnum = CategoriaBultoEnum.L;
            else if (categoriaVerificada.Descripcion == "XL") categoriaEnum = CategoriaBultoEnum.XL;

            // Buscar idTarifaCliente vigente
            int idTarifaCliente = 0;
            TarifaCliente tarifaV = null;
            foreach (TarifaClienteEntidad t in TarifaClienteAlmacen.tarifaClientes)
            {
                if (t.CategoriaBulto == categoriaEnum
                    && t.IdCDOrigen == guiaEntidad.IdCDOrigen
                    && t.IdCDDestino == guiaEntidad.IdCDDestino
                    && t.FechaVigencia <= DateTime.Now)
                {
                    if (tarifaV == null || t.FechaVigencia > tarifaV.FechaVigencia)
                        tarifaV = new TarifaCliente { IdTarifaCliente = t.IdTarifaCliente, FechaVigencia = t.FechaVigencia };
                }
            }
            if (tarifaV != null)
                idTarifaCliente = tarifaV.IdTarifaCliente;

            // Buscar idExtras vigente
            int idExtras = 0;
            Extras extrasVigentes = null;
            foreach (ExtrasEntidad e in ExtrasAlmacen.extrass)
            {
                if (e.FechaVigencia <= DateTime.Now)
                {
                    if (extrasVigentes == null || e.FechaVigencia > extrasVigentes.FechaVigencia)
                        extrasVigentes = new Extras { IdExtras = e.IdExtras, FechaVigencia = e.FechaVigencia };
                }
            }
            if (extrasVigentes != null)
                idExtras = extrasVigentes.IdExtras;

            // Buscar comision agencia vigente por categoria
            int idComisionAgencia = 0;
            ComisionAgencia comisionAgenciaVigente = null;
            foreach (ComisionAgenciaEntidad ca in ComisionAgenciaAlmacen.comisionAgencias)
            {
                if (ca.CategoriaBulto == categoriaEnum && ca.FechaVigencia <= DateTime.Now)
                {
                    if (comisionAgenciaVigente == null || ca.FechaVigencia > comisionAgenciaVigente.FechaVigencia)
                        comisionAgenciaVigente = new ComisionAgencia { IdComisionAgencia = ca.IdComisionAgencia, FechaVigencia = ca.FechaVigencia };
                }
            }
            if (comisionAgenciaVigente != null)
                idComisionAgencia = comisionAgenciaVigente.IdComisionAgencia;

            // Buscar comision fletero vigente por categoria
            int idComisionFletero = 0;
            ComisionFletero comisionFleteroVigente = null;
            foreach (ComisionFleteroEntidad cf in ComisionFleteroAlmacen.comisionFleteros)
            {
                if (cf.CategoriaBulto == categoriaEnum && cf.FechaVigencia <= DateTime.Now)
                {
                    if (comisionFleteroVigente == null || cf.FechaVigencia > comisionFleteroVigente.FechaVigencia)
                        comisionFleteroVigente = new ComisionFletero { IdComisionFletero = cf.IdComisionFletero, FechaVigencia = cf.FechaVigencia };
                }
            }
            if (comisionFleteroVigente != null)
                idComisionFletero = comisionFleteroVigente.IdComisionFletero;

            // Actualizar GuiaEntidad en el almacen
            guiaEntidad.CategoriaBulto = categoriaEnum;
            guiaEntidad.IdTarifaCliente = idTarifaCliente;
            guiaEntidad.IdExtras = idExtras;
            guiaEntidad.TarifaDefinitiva = tarifaDefinitiva;
            guiaEntidad.IdComisionAgencia = idComisionAgencia;
            guiaEntidad.IdComisionFletero = idComisionFletero;

            EstadoGuiaEnum nuevoEstado;

            if (guiaEntidad.IdCDOrigen == guiaEntidad.IdCDDestino)
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
                Fecha = DateTime.Now
            });

            GuiaAlmacen.Guardar();

            // Actualizar objeto local
            GuiaSeleccionada.Categoria = categoriaVerificada.Descripcion;
            GuiaSeleccionada.EstadoActual = nuevoEstado.ToString();

            return true;
        }

        internal void LimpiarSeleccion()
        {
            GuiaSeleccionada = null;
        }
    }
}