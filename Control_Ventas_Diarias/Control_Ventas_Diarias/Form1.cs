using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Ventas_Diarias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if (txtID.Text.Trim() == "")
            {
                errorProvider1.SetError(txtID, "ID obligatorio");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtID, "");
            }
        }

        private void numMonto_Validating(object sender, CancelEventArgs e)
        {
            if (numMonto.Value <= 0)
            {
                errorProvider1.SetError(numMonto, "El monto debe ser mayor a 0");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(numMonto, "");
            }
        }

        private void btnGuardarTransaccion_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!this.ValidateChildren())
            {
                return;
            }

            string ruta = "ventas.txt";

            string linea = txtID.Text + ", " + numMonto.Value.ToString();

            File.AppendAllText(ruta, linea + Environment.NewLine);

            MessageBox.Show("Transacción guardada");

            txtID.Clear();
            numMonto.Value = 0;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lstHistorial.Items.Clear();

            string ruta = "ventas.txt";
            double total = 0;

            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);

                foreach (string linea in lineas)
                {
                    lstHistorial.Items.Add(linea);

                    string[] datos = linea.Split(',');

                    if (datos.Length == 2)
                    {
                        double monto;
                        if (double.TryParse(datos[1].Trim(), out monto))
                        {
                            total += monto;
                        }
                    }
                }

                lblTotal.Text = "TOTAL: $" + total.ToString("0.00");
            }
            else
            {
                MessageBox.Show("No hay ventas registradas");
            }
        }
    }
}
