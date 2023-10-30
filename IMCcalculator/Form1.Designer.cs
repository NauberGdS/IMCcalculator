namespace IMCcalculator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTabela = new System.Windows.Forms.Label();
            this.NumPeso = new System.Windows.Forms.NumericUpDown();
            this.NumAltura = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAltura)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIMC
            // 
            this.txtIMC.Enabled = false;
            this.txtIMC.Location = new System.Drawing.Point(68, 170);
            this.txtIMC.MaxLength = 4;
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(106, 20);
            this.txtIMC.TabIndex = 2;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(27, 69);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(27, 97);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Altura";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(39, 121);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(144, 24);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Location = new System.Drawing.Point(36, 173);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(26, 13);
            this.lblIMC.TabIndex = 6;
            this.lblIMC.Text = "IMC";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 23);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "IMC CALCULATOR";
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Location = new System.Drawing.Point(23, 199);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(0, 13);
            this.lblTabela.TabIndex = 8;
            // 
            // NumPeso
            // 
            this.NumPeso.DecimalPlaces = 2;
            this.NumPeso.Location = new System.Drawing.Point(68, 67);
            this.NumPeso.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.NumPeso.Name = "NumPeso";
            this.NumPeso.Size = new System.Drawing.Size(120, 20);
            this.NumPeso.TabIndex = 9;
            // 
            // NumAltura
            // 
            this.NumAltura.DecimalPlaces = 2;
            this.NumAltura.Location = new System.Drawing.Point(68, 95);
            this.NumAltura.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.NumAltura.Name = "NumAltura";
            this.NumAltura.Size = new System.Drawing.Size(120, 20);
            this.NumAltura.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 228);
            this.Controls.Add(this.NumAltura);
            this.Controls.Add(this.NumPeso);
            this.Controls.Add(this.lblTabela);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtIMC);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAltura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.NumericUpDown NumPeso;
        private System.Windows.Forms.NumericUpDown NumAltura;
    }
}

