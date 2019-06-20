namespace Sistema_Bancario.Controles
{
    partial class TipoCuenta
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RBAhorros = new System.Windows.Forms.RadioButton();
            this.RBCredito = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RBAhorros
            // 
            this.RBAhorros.AutoSize = true;
            this.RBAhorros.Location = new System.Drawing.Point(6, 21);
            this.RBAhorros.Name = "RBAhorros";
            this.RBAhorros.Size = new System.Drawing.Size(79, 21);
            this.RBAhorros.TabIndex = 0;
            this.RBAhorros.TabStop = true;
            this.RBAhorros.Text = "Ahorros";
            this.RBAhorros.UseVisualStyleBackColor = true;
            // 
            // RBCredito
            // 
            this.RBCredito.AutoSize = true;
            this.RBCredito.Location = new System.Drawing.Point(91, 21);
            this.RBCredito.Name = "RBCredito";
            this.RBCredito.Size = new System.Drawing.Size(74, 21);
            this.RBCredito.TabIndex = 1;
            this.RBCredito.TabStop = true;
            this.RBCredito.Text = "Credito";
            this.RBCredito.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBCredito);
            this.groupBox1.Controls.Add(this.RBAhorros);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta";
            // 
            // TipoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "TipoCuenta";
            this.Size = new System.Drawing.Size(184, 64);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton RBAhorros;
        public System.Windows.Forms.RadioButton RBCredito;
    }
}
