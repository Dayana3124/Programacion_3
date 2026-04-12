using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Clientes
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            if (txtDNI.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDNI, "DNI obligatorio");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtDNI, "");
            }
        }
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombre, "Nombre obligatorio");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            
            if (!this.ValidateChildren())
            {
                return;
            }

           
            string ciudad = txtCiudad.Text.Trim();
            if (ciudad == "")
            {
                ciudad = "No especificado";
            }


            string linea = txtDNI.Text + ", " + txtNombre.Text + ", " + ciudad;


            string ruta = "clientes.txt";

            
            File.AppendAllText(ruta, linea + Environment.NewLine);

            MessageBox.Show("Cliente registrado correctamente");

            
            txtDNI.Clear();
            txtNombre.Clear();
            txtCiudad.Clear();
        }

        private void btnCargarClientes_Click(object sender, EventArgs e)
        {
            lstClientes.Items.Clear();

            if (File.Exists("clientes.txt"))
            {
                string[] lineas = File.ReadAllLines("clientes.txt");

                foreach (string linea in lineas)
                {
                    lstClientes.Items.Add(linea);
                }
            }
            else
            {
                MessageBox.Show("No hay archivo de clientes");
            }
        }
    }
}
