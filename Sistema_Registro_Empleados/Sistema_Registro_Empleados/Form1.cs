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

namespace Sistema_Registro_Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            btnRegistrar.BackColor = Color.Green;
            btnRegistrar.ForeColor = Color.White;

            bool valido = true;

            // Mostrar errores SOLO si falla
            if (txtNombres.Text.Trim() == "")
            {
                lblErrorNombres.Visible = true;
                valido = false;
            }

            if (txtApellidos.Text.Trim() == "")
            {
                lblErrorApellidos.Visible = true;
                valido = false;
            }

            if (txtEmail.Text.Trim() == "")
            {
                lblErrorEmail.Visible = true;
                valido = false;
            }
            else
            {
                string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(txtEmail.Text, patronEmail))
                {
                    lblErrorEmail.Text = "Correo inválido";
                    lblErrorEmail.Visible = true;
                    valido = false;
                }
            }

            if (!Regex.IsMatch(txtIdentificacion.Text, @"^\d{10}$"))
            {
                lblErrorIdentificacion.Visible = true;
                valido = false;
            }

            if (cmbDepartamento.SelectedIndex == -1)
            {
                lblErrorDepartamento.Visible = true;
                valido = false;
            }

            if (valido)
            {
                double sueldoBase = (double)numSueldoBase.Value;
                double sueldoNeto = sueldoBase - (sueldoBase * 0.10);

                lblResultadoSueldo.Text = "Sueldo Neto: " + sueldoNeto.ToString("C");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnLimpiar.BackColor = Color.Red;
            btnLimpiar.ForeColor = Color.White;

            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtIdentificacion.Clear();

            cmbDepartamento.SelectedIndex = -1;
            numSueldoBase.Value = 1000;

            lblResultadoSueldo.Text = "Sueldo Neto: $";

            
            lblErrorNombres.Visible = false;
            lblErrorApellidos.Visible = false;
            lblErrorEmail.Visible = false;
            lblErrorIdentificacion.Visible = false;
            lblErrorDepartamento.Visible = false;
        }
        

        private void lblResultadoSueldo_Click(object sender, EventArgs e)
        {

        }
    }
    
}
