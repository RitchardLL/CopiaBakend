namespace Sistema_Bancario.Froms_opciones
{
    partial class Tarjetas
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
            this.nroTarjeta1 = new Sistema_Bancario.Controles.NroTarjeta();
            this.monto1 = new Sistema_Bancario.Monto();
            this.tipoMoneda1 = new Sistema_Bancario.Controles.TipoMoneda();
            this.SuspendLayout();
            // 
            // nroTarjeta1
            // 
            this.nroTarjeta1.Location = new System.Drawing.Point(17, 11);
            this.nroTarjeta1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nroTarjeta1.Name = "nroTarjeta1";
            this.nroTarjeta1.Size = new System.Drawing.Size(260, 28);
            this.nroTarjeta1.TabIndex = 2;
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(17, 105);
            this.monto1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(303, 25);
            this.monto1.TabIndex = 3;
            // 
            // tipoMoneda1
            // 
            this.tipoMoneda1.Location = new System.Drawing.Point(17, 43);
            this.tipoMoneda1.Margin = new System.Windows.Forms.Padding(2);
            this.tipoMoneda1.Name = "tipoMoneda1";
            this.tipoMoneda1.Size = new System.Drawing.Size(183, 58);
            this.tipoMoneda1.TabIndex = 4;
            // 
            // Tarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.tipoMoneda1);
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.nroTarjeta1);
            this.Name = "Tarjetas";
            this.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Controls.SetChildIndex(this.nroTarjeta1, 0);
            this.Controls.SetChildIndex(this.monto1, 0);
            this.Controls.SetChildIndex(this.tipoMoneda1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.NroTarjeta nroTarjeta1;
        private Monto monto1;
        private Controles.TipoMoneda tipoMoneda1;
    }
}
