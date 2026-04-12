namespace Reto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarProcesar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstAprobados = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardarProcesar);
            this.groupBox1.Controls.Add(this.txtNota);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Registro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 180);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Alumno:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(291, 25);
            this.txtNombre.TabIndex = 1;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(456, 59);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(258, 25);
            this.txtNota.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota (0.0 - 5.0):";
            // 
            // btnGuardarProcesar
            // 
            this.btnGuardarProcesar.Location = new System.Drawing.Point(568, 125);
            this.btnGuardarProcesar.Name = "btnGuardarProcesar";
            this.btnGuardarProcesar.Size = new System.Drawing.Size(178, 47);
            this.btnGuardarProcesar.TabIndex = 4;
            this.btnGuardarProcesar.Text = "Guardar y Procesar";
            this.btnGuardarProcesar.UseVisualStyleBackColor = true;
            this.btnGuardarProcesar.Click += new System.EventHandler(this.btnGuardarProcesar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAprobados);
            this.groupBox2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 200);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aprobados (>= 3.0)";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(446, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 200);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deprobados (< 3.0)";
            // 
            // lstAprobados
            // 
            this.lstAprobados.FormattingEnabled = true;
            this.lstAprobados.ItemHeight = 17;
            this.lstAprobados.Location = new System.Drawing.Point(12, 27);
            this.lstAprobados.Name = "lstAprobados";
            this.lstAprobados.Size = new System.Drawing.Size(307, 157);
            this.lstAprobados.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarProcesar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstAprobados;
    }
}

