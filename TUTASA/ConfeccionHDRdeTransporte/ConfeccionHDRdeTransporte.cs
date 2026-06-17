using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUTASA.Almacenes;
using TUTASA.ConfeccionHDRdeTransporte;

namespace TUTASA.Pantallas
{
    public partial class ConfeccionHDRdeTransporte : Form
    {
        // ── Instancia del modelo ──────────────────────────────
        private ConfeccionHDRdeTransporteModelo modelo = new ConfeccionHDRdeTransporteModelo();

        public ConfeccionHDRdeTransporte()
        {
            InitializeComponent();
        }

        // ── LOAD ─────────────────────────────────────────────
        private void ConfeccionHDRdeTransporte_Load(object sender, EventArgs e)
        {
            // CD Origen autorrelleno por sesión
            labelMuestraCDOrigen.Text = CentroDistribucionAlmacen.centroDistribucions
                .Find(cd => cd.IdCD == modelo.IdCDOrigen)?.NombreCD ?? "Sin CD";

            // Cargar CDs destino disponibles desde el CD de sesión
            cmbCDDestino.Items.Clear();
            foreach (var cd in modelo.ObtenerDestinosDisponibles())
                cmbCDDestino.Items.Add(cd.NombreCD);

            // Limpiar resto
            listViewEncomiendas.Items.Clear();
            cmbServicio.Items.Clear();
            labelMuestraTipoArrendamiento.Text = "";
            btnGuardar.Enabled = false;
        }

        // ── CAMBIO DE CD DESTINO ──────────────────────────────
        private void cmbCDDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelo.Limpiando) return;
            if (cmbCDDestino.SelectedIndex < 0) return;

            string nombreCDDestino = cmbCDDestino.SelectedItem.ToString();

            // Buscar el ID del CD destino seleccionado
            var cdDestino = CentroDistribucionAlmacen.centroDistribucions
                .Find(cd => cd.NombreCD == nombreCDDestino);

            if (cdDestino == null) return;

            // Limpiar selección anterior
            modelo.GuiasSeleccionadas.Clear();
            listViewEncomiendas.Items.Clear();
            cmbServicio.Items.Clear();
            cmbServicio.SelectedIndex = -1;
            cmbServicio.Text = "";
            labelMuestraTipoArrendamiento.Text = "";
            btnGuardar.Enabled = false;

            // Cargar empresas que cubren el tramo automáticamente
            var empresas = modelo.ObtenerEmpresasPorTramo(cdDestino.IdCD);

            if (empresas.Count == 0)
            {
                MessageBox.Show(
                    "No hay empresas de transporte disponibles para el destino seleccionado.",
                    "Sin empresas disponibles",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            foreach (var emp in empresas)
                cmbServicio.Items.Add(emp.NombreEmpresa);
        }

        // ── CAMBIO DE SERVICIO ───────────────────────────────
        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServicio.SelectedIndex < 0) return;

            string nombreCDDestino = cmbCDDestino.SelectedItem.ToString();
            var cdDestino = CentroDistribucionAlmacen.centroDistribucions
                .Find(cd => cd.NombreCD == nombreCDDestino);

            var empresas = modelo.ObtenerEmpresasPorTramo(cdDestino.IdCD);
            EmpresaTransporte empresaSeleccionada = empresas[cmbServicio.SelectedIndex];

            // Mostrar tipo de arrendamiento preacordado con la empresa
            labelMuestraTipoArrendamiento.Text = empresaSeleccionada.TipoArrendamiento.ToString();

            // Limpiar guías seleccionadas al cambiar de servicio
            modelo.GuiasSeleccionadas.Clear();
            listViewEncomiendas.Items.Clear();
            btnGuardar.Enabled = false;

            // Cargar guías admitidas para ese CD destino
            var guias = modelo.ObtenerGuiasPorCDDestino(cdDestino.IdCD);

            if (guias.Count == 0)
            {
                MessageBox.Show(
                    "No existen encomiendas admitidas para el destino seleccionado.",
                    "Sin encomiendas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Cargar guías en la ListView
            foreach (var g in guias)
            {
                ListViewItem item = new ListViewItem(g.NroTracking);
                item.SubItems.Add(g.Categoria);
                item.SubItems.Add(g.CdDestino);
                item.Tag = g;
                listViewEncomiendas.Items.Add(item);
            }
        }

        // ── SELECCIÓN DE ENCOMIENDAS VIA CHECKBOX ────────────
        private void listViewEncomiendas_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (modelo.Limpiando) return;
            if (cmbServicio.SelectedIndex < 0) return;

            string nombreCDDestino = cmbCDDestino.SelectedItem.ToString();
            var cdDestino = CentroDistribucionAlmacen.centroDistribucions
                .Find(cd => cd.NombreCD == nombreCDDestino);
            var empresas = modelo.ObtenerEmpresasPorTramo(cdDestino.IdCD);
            EmpresaTransporte empresaSeleccionada = empresas[cmbServicio.SelectedIndex];

            // Si se está tildando
            if (e.Item.Checked)
            {
                Guia guiaAAgregar = (Guia)e.Item.Tag;

                // Verificar si supera el límite
                if (modelo.SuperaLimite(guiaAAgregar, empresaSeleccionada.TipoArrendamiento))
                {
                    modelo.Limpiando = true;
                    e.Item.Checked = false;
                    modelo.Limpiando = false;

                    MessageBox.Show(
                        "No se pueden agregar más guías. Se ha alcanzado el límite de capacidad del tipo de arrendamiento " +
                        empresaSeleccionada.TipoArrendamiento.ToString() + ".",
                        "Límite alcanzado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            // Recalcular guías seleccionadas
            modelo.GuiasSeleccionadas.Clear();
            foreach (ListViewItem item in listViewEncomiendas.Items)
            {
                if (item.Checked)
                    modelo.GuiasSeleccionadas.Add((Guia)item.Tag);
            }

            btnGuardar.Enabled = modelo.GuiasSeleccionadas.Count > 0;
        }

        // ── GUARDAR ──────────────────────────────────────────
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modelo.GuiasSeleccionadas.Count == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar al menos una encomienda para confeccionar la HDR.",
                    "Sin encomiendas seleccionadas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbServicio.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Debe seleccionar un servicio de transporte.",
                    "Servicio no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string nombreCDDestino = cmbCDDestino.SelectedItem.ToString();
            var cdDestino = CentroDistribucionAlmacen.centroDistribucions
                .Find(cd => cd.NombreCD == nombreCDDestino);
            var empresas = modelo.ObtenerEmpresasPorTramo(cdDestino.IdCD);
            EmpresaTransporte empresaSeleccionada = empresas[cmbServicio.SelectedIndex];

            DialogResult confirmacion = MessageBox.Show(
                "¿Confirma la confección de la HDR de transporte con " + modelo.GuiasSeleccionadas.Count +
                " encomienda(s) vía " + empresaSeleccionada.NombreEmpresa + "?",
                "Confirmar HDR",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            modelo.GuardarHDR(empresaSeleccionada, cdDestino.IdCD);

            MessageBox.Show(
                "La HDR de transporte fue confeccionada correctamente.",
                "HDR Confeccionada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Limpiar pantalla
            modelo.Limpiando = true;
            cmbCDDestino.SelectedIndex = -1;
            cmbCDDestino.Text = "";
            listViewEncomiendas.Items.Clear();
            cmbServicio.Items.Clear();
            cmbServicio.Text = "";
            labelMuestraTipoArrendamiento.Text = "";
            btnGuardar.Enabled = false;
            modelo.Limpiando = false;
        }

        // ── CANCELAR ─────────────────────────────────────────
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}