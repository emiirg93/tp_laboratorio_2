namespace MiCalculadora
{
    partial class LaCalculadora
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaCalculadora));
            this.btnComvertirADecimal = new System.Windows.Forms.Button();
            this.btnConvertirABinario = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.bntCerrar = new System.Windows.Forms.Button();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.EtiquetaResultado = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComvertirADecimal
            // 
            this.btnComvertirADecimal.Location = new System.Drawing.Point(252, 185);
            this.btnComvertirADecimal.Name = "btnComvertirADecimal";
            this.btnComvertirADecimal.Size = new System.Drawing.Size(225, 48);
            this.btnComvertirADecimal.TabIndex = 0;
            this.btnComvertirADecimal.Text = "Convertir A Decimal";
            this.btnComvertirADecimal.UseVisualStyleBackColor = true;
            this.btnComvertirADecimal.Click += new System.EventHandler(this.btnComvertirADecimal_Click);
            // 
            // btnConvertirABinario
            // 
            this.btnConvertirABinario.Location = new System.Drawing.Point(12, 185);
            this.btnConvertirABinario.Name = "btnConvertirABinario";
            this.btnConvertirABinario.Size = new System.Drawing.Size(225, 48);
            this.btnConvertirABinario.TabIndex = 1;
            this.btnConvertirABinario.Text = "Convertir A Binario";
            this.btnConvertirABinario.UseVisualStyleBackColor = true;
            this.btnConvertirABinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(12, 145);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(158, 34);
            this.btnOperar.TabIndex = 2;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(176, 145);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 34);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // bntCerrar
            // 
            this.bntCerrar.Location = new System.Drawing.Point(322, 145);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(155, 34);
            this.bntCerrar.TabIndex = 4;
            this.bntCerrar.Text = "Cerrar";
            this.bntCerrar.UseVisualStyleBackColor = true;
            this.bntCerrar.Click += new System.EventHandler(this.bntCerrar_Click);
            // 
            // cmbOperador
            // 
            this.cmbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Location = new System.Drawing.Point(189, 76);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(115, 54);
            this.cmbOperador.TabIndex = 5;
            // 
            // EtiquetaResultado
            // 
            this.EtiquetaResultado.AutoSize = true;
            this.EtiquetaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaResultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EtiquetaResultado.Location = new System.Drawing.Point(12, 9);
            this.EtiquetaResultado.Name = "EtiquetaResultado";
            this.EtiquetaResultado.Size = new System.Drawing.Size(82, 13);
            this.EtiquetaResultado.TabIndex = 6;
            this.EtiquetaResultado.Text = "RESULTADO";
            this.EtiquetaResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtNumero1.Location = new System.Drawing.Point(12, 76);
            this.txtNumero1.Multiline = true;
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(158, 54);
            this.txtNumero1.TabIndex = 7;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtNumero2.Location = new System.Drawing.Point(322, 76);
            this.txtNumero2.Multiline = true;
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(158, 54);
            this.txtNumero2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(426, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 46);
            this.label2.TabIndex = 9;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblResultado.Location = new System.Drawing.Point(12, 27);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(46, 46);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "--";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LaCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 242);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.EtiquetaResultado);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.bntCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnConvertirABinario);
            this.Controls.Add(this.btnComvertirADecimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LaCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora De Emiliano Miguel Rago Y Fernandez Del Curso 2A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComvertirADecimal;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button bntCerrar;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Label EtiquetaResultado;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;

    }
}

