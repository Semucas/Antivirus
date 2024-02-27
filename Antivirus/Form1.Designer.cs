namespace Antivirus
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.textTitulo = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonAnalizar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textEstado = new System.Windows.Forms.Label();
            this.textArchivo = new System.Windows.Forms.Label();
            this.textVirus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textoVirus = new System.Windows.Forms.Label();
            this.textoArchivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textTitulo
            // 
            this.textTitulo.AutoSize = true;
            this.textTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitulo.Location = new System.Drawing.Point(181, 47);
            this.textTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(282, 38);
            this.textTitulo.TabIndex = 0;
            this.textTitulo.Text = "Detector de virus";
            this.textTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscar.Location = new System.Drawing.Point(606, 117);
            this.botonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(100, 28);
            this.botonBuscar.TabIndex = 2;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonAnalizar
            // 
            this.botonAnalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAnalizar.Location = new System.Drawing.Point(606, 353);
            this.botonAnalizar.Margin = new System.Windows.Forms.Padding(4);
            this.botonAnalizar.Name = "botonAnalizar";
            this.botonAnalizar.Size = new System.Drawing.Size(116, 28);
            this.botonAnalizar.TabIndex = 3;
            this.botonAnalizar.Text = "Analizar";
            this.botonAnalizar.UseVisualStyleBackColor = true;
            this.botonAnalizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 194);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(483, 187);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // textEstado
            // 
            this.textEstado.AutoSize = true;
            this.textEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEstado.Location = new System.Drawing.Point(601, 165);
            this.textEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(79, 25);
            this.textEstado.TabIndex = 5;
            this.textEstado.Text = "Estado";
            this.textEstado.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textArchivo
            // 
            this.textArchivo.AutoSize = true;
            this.textArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArchivo.Location = new System.Drawing.Point(601, 217);
            this.textArchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textArchivo.Name = "textArchivo";
            this.textArchivo.Size = new System.Drawing.Size(85, 25);
            this.textArchivo.TabIndex = 6;
            this.textArchivo.Text = "Archivo";
            // 
            // textVirus
            // 
            this.textVirus.AutoSize = true;
            this.textVirus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVirus.Location = new System.Drawing.Point(601, 272);
            this.textVirus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textVirus.Name = "textVirus";
            this.textVirus.Size = new System.Drawing.Size(62, 25);
            this.textVirus.TabIndex = 7;
            this.textVirus.Text = "Virus";
            this.textVirus.Click += new System.EventHandler(this.textVirus_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(69, 123);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(483, 28);
            this.textBox1.TabIndex = 8;
            // 
            // textoVirus
            // 
            this.textoVirus.AutoSize = true;
            this.textoVirus.Location = new System.Drawing.Point(603, 312);
            this.textoVirus.Name = "textoVirus";
            this.textoVirus.Size = new System.Drawing.Size(0, 16);
            this.textoVirus.TabIndex = 9;
            // 
            // textoArchivo
            // 
            this.textoArchivo.AutoSize = true;
            this.textoArchivo.Location = new System.Drawing.Point(606, 246);
            this.textoArchivo.Name = "textoArchivo";
            this.textoArchivo.Size = new System.Drawing.Size(0, 16);
            this.textoArchivo.TabIndex = 10;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 420);
            this.Controls.Add(this.textoArchivo);
            this.Controls.Add(this.textoVirus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textVirus);
            this.Controls.Add(this.textArchivo);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.botonAnalizar);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.textTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANTIVIRUS SEBAS ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textTitulo;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonAnalizar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label textEstado;
        private System.Windows.Forms.Label textArchivo;
        private System.Windows.Forms.Label textVirus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label textoVirus;
        private System.Windows.Forms.Label textoArchivo;
    }
}

