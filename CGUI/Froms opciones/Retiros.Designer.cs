namespace Sistema_Bancario.Froms_opciones
{
    partial class Retiros
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
            this.monto1 = new Sistema_Bancario.Monto();
            this.disponible1 = new Sistema_Bancario.Controles.Disponible();
            this.nro_Tarjeta1 = new Sistema_Bancario.Controles.NroTarjeta();
            this.clave1 = new Sistema_Bancario.Controles.Clave();
            this.SuspendLayout();
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(8, 8);
            this.monto1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(308, 25);
            this.monto1.TabIndex = 3;
            // 
            // disponible1
            // 
            this.disponible1.Location = new System.Drawing.Point(8, 37);
            this.disponible1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.disponible1.Name = "disponible1";
            this.disponible1.Size = new System.Drawing.Size(314, 28);
            this.disponible1.TabIndex = 4;
            // 
            // nro_Tarjeta1
            // 
            this.nro_Tarjeta1.Location = new System.Drawing.Point(10, 69);
            this.nro_Tarjeta1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nro_Tarjeta1.Name = "nro_Tarjeta1";
            this.nro_Tarjeta1.Size = new System.Drawing.Size(262, 28);
            this.nro_Tarjeta1.TabIndex = 5;
            // 
            // clave1
            // 
            this.clave1.Location = new System.Drawing.Point(8, 101);
            this.clave1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clave1.Name = "clave1";
            this.clave1.Size = new System.Drawing.Size(298, 28);
            this.clave1.TabIndex = 6;
            // 
            // Retiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.clave1);
            this.Controls.Add(this.nro_Tarjeta1);
            this.Controls.Add(this.disponible1);
            this.Controls.Add(this.monto1);
            this.Name = "Retiros";
            this.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Controls.SetChildIndex(this.monto1, 0);
            this.Controls.SetChildIndex(this.disponible1, 0);
            this.Controls.SetChildIndex(this.nro_Tarjeta1, 0);
            this.Controls.SetChildIndex(this.clave1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Monto monto1;
        private Controles.Disponible disponible1;
        private Controles.NroTarjeta nro_Tarjeta1;
        private Controles.Clave clave1;
    }
}
