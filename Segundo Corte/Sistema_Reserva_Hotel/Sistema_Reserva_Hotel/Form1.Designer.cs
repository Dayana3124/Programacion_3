namespace Sistema_Reserva_Hotel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numPersonas = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.clbServicios = new System.Windows.Forms.CheckedListBox();
            this.rtbResumen = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcularReserva = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE RESERVA DE HOTEL";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(156, 77);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(239, 20);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.Validating += new System.ComponentModel.CancelEventHandler(this.txtCliente_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE DEL CLIENTE:";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Location = new System.Drawing.Point(127, 112);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(231, 20);
            this.dtpEntrada.TabIndex = 3;
            this.dtpEntrada.Validating += new System.ComponentModel.CancelEventHandler(this.dtpEntrada_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "FECHA ENTRADA:";
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(127, 143);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(231, 20);
            this.dtpSalida.TabIndex = 5;
            this.dtpSalida.Validating += new System.ComponentModel.CancelEventHandler(this.dtpSalida_Validatin);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "FECHA SALIDA:";
            // 
            // numPersonas
            // 
            this.numPersonas.Location = new System.Drawing.Point(166, 174);
            this.numPersonas.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPersonas.Name = "numPersonas";
            this.numPersonas.Size = new System.Drawing.Size(120, 20);
            this.numPersonas.TabIndex = 7;
            this.numPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPersonas.ValueChanged += new System.EventHandler(this.numPersonas_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "NUMERO DE PERSONAS:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // clbServicios
            // 
            this.clbServicios.FormattingEnabled = true;
            this.clbServicios.Items.AddRange(new object[] {
            "WiFi Premium",
            "Desayuno ",
            "Buffet",
            "Estacionamiento",
            "Spa"});
            this.clbServicios.Location = new System.Drawing.Point(14, 246);
            this.clbServicios.Name = "clbServicios";
            this.clbServicios.Size = new System.Drawing.Size(148, 79);
            this.clbServicios.TabIndex = 9;
            // 
            // rtbResumen
            // 
            this.rtbResumen.BackColor = System.Drawing.Color.LavenderBlush;
            this.rtbResumen.Location = new System.Drawing.Point(369, 225);
            this.rtbResumen.Name = "rtbResumen";
            this.rtbResumen.ReadOnly = true;
            this.rtbResumen.Size = new System.Drawing.Size(364, 213);
            this.rtbResumen.TabIndex = 10;
            this.rtbResumen.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.Location = new System.Drawing.Point(12, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "ARTICULOS:";
            // 
            // btnCalcularReserva
            // 
            this.btnCalcularReserva.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCalcularReserva.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularReserva.Location = new System.Drawing.Point(15, 375);
            this.btnCalcularReserva.Name = "btnCalcularReserva";
            this.btnCalcularReserva.Size = new System.Drawing.Size(157, 63);
            this.btnCalcularReserva.TabIndex = 14;
            this.btnCalcularReserva.Text = "CALCULAR RESERVA";
            this.btnCalcularReserva.UseVisualStyleBackColor = false;
            this.btnCalcularReserva.Click += new System.EventHandler(this.btnCalcularReserva_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularReserva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbResumen);
            this.Controls.Add(this.clbServicios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numPersonas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPersonas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox clbServicios;
        private System.Windows.Forms.RichTextBox rtbResumen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcularReserva;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

