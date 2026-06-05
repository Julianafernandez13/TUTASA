using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUTASA.CostovsVentas;

namespace TUTASA.Forms.Administracion
{
    public partial class CostovsVentas : Form
    {
        private CostovsVentasModelo modelo = new CostovsVentasModelo();

        public CostovsVentas()
        {
            InitializeComponent();
        }

        private void CostovsVentas_Load(object sender, EventArgs e)
        {
            // Cargar meses
            cmbMes.Items.Clear();
            cmbMes.Items.Add("Enero");
            cmbMes.Items.Add("Febrero");
            cmbMes.Items.Add("Marzo");
            cmbMes.Items.Add("Abril");
            cmbMes.Items.Add("Mayo");
            cmbMes.Items.Add("Junio");
            cmbMes.Items.Add("Julio");
            cmbMes.Items.Add("Agosto");
            cmbMes.Items.Add("Septiembre");
            cmbMes.Items.Add("Octubre");
            cmbMes.Items.Add("Noviembre");
            cmbMes.Items.Add("Diciembre");

            // Cargar años (rango fijo)
            cmbAño.Items.Clear();
            for (int anio = 2023; anio <= 2026; anio++)
                cmbAño.Items.Add(anio.ToString());

            // Cargar empresas desde el modelo
            cmbEmpresa.Items.Clear();
            foreach (string emp in modelo.ObtenerEmpresas())
                cmbEmpresa.Items.Add(emp);

            // Limpiar grilla y totales
            LimpiarPantalla();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (cmbMes.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un mes.", "Dato faltante",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMes.Focus();
                return;
            }

            if (cmbAño.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un año.", "Dato faltante",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAño.Focus();
                return;
            }

            if (cmbEmpresa.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una empresa", "Dato faltante",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEmpresa.Focus();
                return;
            }

            int mes = cmbMes.SelectedIndex + 1;
            int anio = int.Parse(cmbAño.SelectedItem.ToString());
            string empresa = cmbEmpresa.SelectedItem.ToString();

            List<ResultadoEmpresa> resultados = modelo.GenerarReporte(mes, anio, empresa);

            if (resultados.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron datos para los filtros seleccionados.\nVerifique el período o la empresa indicada.",
                    "Sin resultados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarPantalla();
                return;
            }

            // Cargar resultados en el ListView
            listViewResultados.Items.Clear();

            decimal totalIngresos = 0;
            decimal totalCostos = 0;
            decimal totalMargen = 0;

            foreach (ResultadoEmpresa r in resultados)
            {
                ListViewItem item = new ListViewItem(r.Clasificacion);
                item.SubItems.Add(r.Ingresos.ToString("N2"));
                item.SubItems.Add(r.Costos.ToString("N2"));
                item.SubItems.Add(r.MargenNeto.ToString("N2"));

                listViewResultados.Items.Add(item);

                totalIngresos += r.Ingresos;
                totalCostos += r.Costos;
                totalMargen += r.MargenNeto;
            }

            lblTotales.Text = string.Format(
                "Totales — Ingresos: ${0}  |  Costos: ${1}  |  Margen: ${2}",
                totalIngresos.ToString("N2"),
                totalCostos.ToString("N2"),
                totalMargen.ToString("N2"));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
            cmbMes.SelectedIndex = -1;
            cmbAño.SelectedIndex = -1;
            cmbEmpresa.SelectedIndex = -1;
            cmbMes.Focus();
        }

        private void LimpiarPantalla()
        {
            listViewResultados.Items.Clear();
            lblTotales.Text = "Totales: Ingresos / Costos / Margen";
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
