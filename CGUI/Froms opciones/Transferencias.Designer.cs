namespace Sistema_Bancario.Froms_opciones
{
    partial class Transferencias
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
            this.disponible1 = new Sistema_Bancario.Controles.Disponible();
            this.monto1 = new Sistema_Bancario.Monto();
            this.nroCuenta1 = new Sistema_Bancario.Controles.NroCuenta();
            this.nroCuenta2 = new Sistema_Bancario.Controles.NroCuenta();
            this.SuspendLayout();
            // 
            // disponible1
            // 
            this.disponible1.Location = new System.Drawing.Point(396, 12);
            this.disponible1.Name = "disponible1";
            this.disponible1.Size = new System.Drawing.Size(215, 35);
            this.disponible1.TabIndex = 2;
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(13, 53);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(404, 31);
            this.monto1.TabIndex = 3;
            // 
            // nroCuenta1
            // 
            this.nroCuenta1.Location = new System.Drawing.Point(10, 13);
            this.nroCuenta1.Name = "nroCuenta1";
            this.nroCuenta1.Size = new System.Drawing.Size(360, 37);
            this.nroCuenta1.TabIndex = 4;
            // 
            // nroCuenta2
            // 
            this.nroCuenta2.Location = new System.Drawing.Point(14, 90);
            this.nroCuenta2.Name = "nroCuenta2";
            this.nroCuenta2.Size = new System.Drawing.Size(360, 37);
            this.nroCuenta2.TabIndex = 5;
            // 
            // Transferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(671, 352);
            this.Controls.Add(this.nroCuenta2);
            this.Controls.Add(this.nroCuenta1);
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.disponible1);
            this.Name = "Transferencias";
            this.Controls.SetChildIndex(this.disponible1, 0);
            this.Controls.SetChildIndex(this.monto1, 0);
            this.Controls.SetChildIndex(this.nroCuenta1, 0);
            this.Controls.SetChildIndex(this.nroCuenta2, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.Disponible disponible1;
        private Monto monto1;
        private Controles.NroCuenta nroCuenta1;
        private Controles.NroCuenta nroCuenta2;
    }
}
