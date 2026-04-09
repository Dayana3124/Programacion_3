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

        private async void btnGuardar_Click(object sender, EventArgs e)
        {


            if (txtCodigo.Text.Trim() == "" ||
         txtNombreProducto.Text.Trim() == "" ||
         cmbCategoria.SelectedIndex == -1)
            {
                btnGuardar.BackColor = Color.Red;
                btnGuardar.ForeColor = Color.White;

                await Task.Delay(1000);

                btnGuardar.BackColor = Color.Peru; 
                btnGuardar.ForeColor = Color.Black;

                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            string codigo = txtCodigo.Text.Trim();

            if (codigo.Length != 9 ||
                codigo.Substring(0, 5).ToUpper() != "PROD-" ||
                !int.TryParse(codigo.Substring(5, 4), out _))
            {
                btnGuardar.BackColor = Color.Red;
                btnGuardar.ForeColor = Color.White;

                await Task.Delay(1000);

                btnGuardar.BackColor = Color.Peru;
                btnGuardar.ForeColor = Color.Black;

                MessageBox.Show("El código debe tener el formato PROD-0000");
                return;
            }

            if (numStockInicial.Value < numStockMinimo.Value)
            {
                btnGuardar.BackColor = Color.Red;
                btnGuardar.ForeColor = Color.White;

                await Task.Delay(1000);

                btnGuardar.BackColor = Color.Peru;
                btnGuardar.ForeColor = Color.Black;

                MessageBox.Show("El stock inicial no puede ser menor al stock mínimo");
                return;
            }

            if (!rbExento.Checked && !rbGeneral.Checked && !rbReducido.Checked)
            {
                btnGuardar.BackColor = Color.Red;
                btnGuardar.ForeColor = Color.White;

                await Task.Delay(1000);

                btnGuardar.BackColor = Color.Peru;
                btnGuardar.ForeColor = Color.Black;

                MessageBox.Show("Debe seleccionar un tipo de IVA");
                return;
            }

            if (chkEsPerecedero.Checked && dtpFechaVencimiento.Value <= DateTime.Now)
            {
                btnGuardar.BackColor = Color.Red;
                btnGuardar.ForeColor = Color.White;

                await Task.Delay(1000);

                btnGuardar.BackColor = Color.Peru;
                btnGuardar.ForeColor = Color.Black;

                MessageBox.Show("La fecha de vencimiento debe ser futura");
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

            MessageBox.Show("Formulario limpio");
        }
    }
    
    
    
}
