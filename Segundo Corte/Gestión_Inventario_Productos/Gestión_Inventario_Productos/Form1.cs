using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_Inventario_Productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkEsPerecedero_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaVencimiento.Enabled = chkEsPerecedero.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       

        private void txtNombreProducto_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombreProducto.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombreProducto, "Campo obligatorio");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtNombreProducto, "");
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();

            if (codigo.Length != 9 ||
                codigo.Substring(0, 5).ToUpper() != "PROD-" ||
                !int.TryParse(codigo.Substring(5, 4), out _))
            {
                errorProvider1.SetError(txtCodigo, "Formato: PROD-0000");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtCodigo, "");
        }

        private void cmbCategoria_Validating(object sender, CancelEventArgs e)
        {
            if (cmbCategoria.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbCategoria, "Seleccione una categoría");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cmbCategoria, "");
        }

        private void numStockInicial_Validating(object sender, CancelEventArgs e)
        {
            if (numStockInicial.Value < numStockMinimo.Value)
            {
                errorProvider1.SetError(numStockInicial, "Debe ser mayor o igual al mínimo");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(numStockInicial, "");
        }

        private void groupBoxIVA_Validating(object sender, CancelEventArgs e)
        {
            if (!rbExento.Checked && !rbGeneral.Checked && !rbReducido.Checked)
            {
                errorProvider1.SetError(groupBoxIVA, "Seleccione un IVA");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(groupBoxIVA, "");
        }

        private void dtpFechaVencimiento_Validating(object sender, CancelEventArgs e)
        {
            if (chkEsPerecedero.Checked && dtpFechaVencimiento.Value <= DateTime.Now)
            {
                errorProvider1.SetError(dtpFechaVencimiento, "Fecha inválida");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(dtpFechaVencimiento, "");
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!this.ValidateChildren())
            {
                btnGuardar.BackColor = Color.Red;
                btnGuardar.ForeColor = Color.White;

                await Task.Delay(1000);

                btnGuardar.BackColor = Color.Peru;
                btnGuardar.ForeColor = Color.Black;

                return;
            }

            btnGuardar.BackColor = Color.Green;
            btnGuardar.ForeColor = Color.White;

            await Task.Delay(1000);

            btnGuardar.BackColor = Color.Peru;
            btnGuardar.ForeColor = Color.Black;

            MessageBox.Show("Producto registrado correctamente");
        }

        private async void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnLimpiar.BackColor = Color.Orange;
            btnLimpiar.ForeColor = Color.White;

            await Task.Delay(1000);

            btnLimpiar.BackColor = Color.PaleGoldenrod;
            btnLimpiar.ForeColor = Color.Black;

            txtCodigo.Clear();
            txtNombreProducto.Clear();

            cmbCategoria.SelectedIndex = -1;

            numStockInicial.Value = 0;
            numStockMinimo.Value = 0;

            rbExento.Checked = false;
            rbGeneral.Checked = false;
            rbReducido.Checked = false;

            chkEsPerecedero.Checked = false;
            dtpFechaVencimiento.Enabled = false;

            errorProvider1.Clear();

            MessageBox.Show("Formulario limpio");
        }

    }



}
