using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Reserva_Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


            

        private void numPersonas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCliente_Validating(object sender, CancelEventArgs e)
        {
            if (txtCliente.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCliente, "Debe ingresar el nombre");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCliente, "");
            }
        }

        
        private void dtpEntrada_Validating(object sender, CancelEventArgs e)
        {
            if (dtpEntrada.Value.Date < DateTime.Today)
            {
                errorProvider1.SetError(dtpEntrada, "Fecha inválida");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(dtpEntrada, "");
            }
        }

     

        private void dtpSalida_Validatin(object sender, CancelEventArgs e)
        {
            if (dtpSalida.Value.Date <= dtpEntrada.Value.Date)
            {
                errorProvider1.SetError(dtpSalida, "Debe ser mayor a la entrada");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(dtpSalida, "");
            }
        }


        private async void btnCalcularReserva_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();

            if (txtCliente.Text.Trim() == "")
            {
                btnCalcularReserva.BackColor = Color.Red;
                btnCalcularReserva.ForeColor = Color.White;

                await Task.Delay(1000);

                btnCalcularReserva.BackColor = Color.LightSkyBlue;
                btnCalcularReserva.ForeColor = Color.Black;

                MessageBox.Show("Ingrese el nombre del cliente");
                return;
            }

            DateTime entrada = dtpEntrada.Value.Date;
            DateTime salida = dtpSalida.Value.Date;

            if (entrada < DateTime.Today)
            {
                btnCalcularReserva.BackColor = Color.Red;
                btnCalcularReserva.ForeColor = Color.White;

                await Task.Delay(1000);

                btnCalcularReserva.BackColor = Color.LightSkyBlue;
                btnCalcularReserva.ForeColor = Color.Black;

                MessageBox.Show("La fecha de entrada no puede ser anterior a hoy");
                return;
            }

            if (salida <= entrada)
            {
                btnCalcularReserva.BackColor = Color.Red;
                btnCalcularReserva.ForeColor = Color.White;

                await Task.Delay(1000);

                btnCalcularReserva.BackColor = Color.LightSkyBlue;
                btnCalcularReserva.ForeColor = Color.Black;

                MessageBox.Show("La fecha de salida debe ser al menos un día después");
                return;
            }

            int dias = (salida - entrada).Days;
            int personas = (int)numPersonas.Value;

            double costoBase = dias * 50;

            double costoPersonas = 0;
            if (personas > 1)
                costoPersonas = (personas - 1) * 15 * dias;

            double costoServicios = 0;
            string listaServicios = "";

            foreach (var item in clbServicios.CheckedItems)
            {
                costoServicios += 10 * dias;
                listaServicios += "- " + item.ToString() + "\n";
            }

            if (listaServicios == "")
                listaServicios = "Ninguno\n";

            double total = costoBase + costoPersonas + costoServicios;

            rtbResumen.Text =
                "--- RESUMEN DE RESERVA ---\n\n" +
                "Cliente: " + txtCliente.Text + "\n" +
                "Estancia: " + dias + " noches\n" +
                "Personas: " + personas + "\n\n" +
                "Servicios:\n" + listaServicios + "\n" +
                "--------------------------\n" +
                "TOTAL A PAGAR: $" + total.ToString("0.00");


            btnCalcularReserva.BackColor = Color.Green;
            btnCalcularReserva.ForeColor = Color.White;

            await Task.Delay(1000);

            btnCalcularReserva.BackColor = Color.LightSkyBlue;
            btnCalcularReserva.ForeColor = Color.Black;
        }
    }
    
    
    
}
