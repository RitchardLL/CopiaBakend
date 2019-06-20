namespace Sistema_Bancario.Froms_opciones
{
    partial class Envio_Giros
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
            this.DNI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monto1 = new Sistema_Bancario.Monto();
            this.clave1 = new Sistema_Bancario.Controles.Clave();
            this.dni1 = new Sistema_Bancario.Controles.DNI();
            this.dni2 = new Sistema_Bancario.Controles.DNI();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(8, 236);
            this.proceder1.Size = new System.Drawing.Size(574, 49);
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(17, 36);
            this.DNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(31, 17);
            this.DNI.TabIndex = 6;
            this.DNI.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "DNI Destino";
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(13, 75);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(315, 31);
            this.monto1.TabIndex = 10;
            // 
            // clave1
            // 
            this.clave1.Location = new System.Drawing.Point(13, 123);
            this.clave1.Name = "clave1";
            this.clave1.Size = new System.Drawing.Size(233, 32);
            this.clave1.TabIndex = 11;
            // 
            // dni1
            // 
            this.dni1.Location = new System.Drawing.Point(50, 30);
            this.dni1.Name = "dni1";
            this.dni1.Size = new System.Drawing.Size(196, 31);
            this.dni1.TabIndex = 12;
            // 
            // dni2
            // 
            this.dni2.Location = new System.Drawing.Point(335, 30);
            this.dni2.Name = "dni2";
            this.dni2.Size = new System.Drawing.Size(196, 31);
            this.dni2.TabIndex = 13;
            // 
            // Envio_Giros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.dni2);
            this.Controls.Add(this.dni1);
            this.Controls.Add(this.clave1);
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DNI);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Envio_Giros";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Size = new System.Drawing.Size(590, 292);
            this.Controls.SetChildIndex(this.DNI, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.monto1, 0);
            this.Controls.SetChildIndex(this.clave1, 0);
            this.Controls.SetChildIndex(this.dni1, 0);
            this.Controls.SetChildIndex(this.dni2, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label label2;
        private Monto monto1;
        private Controles.Clave clave1;
        private Controles.DNI dni1;
        private Controles.DNI dni2;
    }
}
