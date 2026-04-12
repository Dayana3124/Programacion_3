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

namespace Reto
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
        string ruta = "estudiantes.cvs";

        private void btnGuardarProcesar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double nota = double.Parse(txtNota.Text);

            string linea = nombre + ", " + nota;    

            File.AppendAllText ( ruta , linea + Environment.NewLine);
        }
    }
}
