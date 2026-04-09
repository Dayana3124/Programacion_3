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

      
        

        private void lblResultadoSueldo_Click(object sender, EventArgs e)
        {

        }

       
        

        private void txtNombres_Validating(object sender, CancelEventArgs e)
        {

            if (txtNombres.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombres, "Ingrese nombres");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtNombres, "");
        }

        private void txtApellidos_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidos.Text.Trim() == "")
            {
                errorProvider1.SetError(txtApellidos, "Ingrese apellidos");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtApellidos, "");
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtEmail.Text, patron))
            {
                errorProvider1.SetError(txtEmail, "Correo inválido");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtEmail, "");
        }
        private void txtIdentificacion_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtIdentificacion.Text, @"^\d{10}$"))
            {
                errorProvider1.SetError(txtIdentificacion, "Debe tener 10 dígitos");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtIdentificacion, "");
        }

        
        

        private void cmbDepartamento_Validating(object sender, CancelEventArgs e)
        {
            if (cmbDepartamento.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbDepartamento, "Seleccione un departamento");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cmbDepartamento, "");
        }
        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

           
            if (!this.ValidateChildren())
            {
                btnRegistrar.BackColor = Color.Red;
                btnRegistrar.ForeColor = Color.White;

                await Task.Delay(1000);

                btnRegistrar.BackColor = Color.PaleGoldenrod;
                btnRegistrar.ForeColor = Color.Black;

                return;
            }

            
            double sueldoBase = (double)numSueldoBase.Value;
            double sueldoNeto = sueldoBase - (sueldoBase * 0.10);

            lblResultadoSueldo.Text = "Sueldo Neto: " + sueldoNeto.ToString("C");

            
            btnRegistrar.BackColor = Color.Green;
            btnRegistrar.ForeColor = Color.White;

            await Task.Delay(1000);

            btnRegistrar.BackColor = Color.PaleGoldenrod;
            btnRegistrar.ForeColor = Color.Black;

            MessageBox.Show("Empleado registrado correctamente");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtIdentificacion.Clear();

            cmbDepartamento.SelectedIndex = -1;
            numSueldoBase.Value = 1000;

            lblResultadoSueldo.Text = "Sueldo Neto: $";

            errorProvider1.Clear();
        }
    }
    
    
}
