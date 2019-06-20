namespace Sistema_Bancario.Froms_opciones
{
    partial class Tipo_de_Cambio
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
            this.tipo1 = new Sistema_Bancario.Controles.Tipo();
            this.monto1 = new Sistema_Bancario.Monto();
            this.tipoMoneda1 = new Sistema_Bancario.Controles.TipoMoneda();
            this.conversion1 = new Sistema_Bancario.Controles.Conversion();
            this.tipoMoneda2 = new Sistema_Bancario.Controles.TipoMoneda();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tipo1
            // 
            this.tipo1.Location = new System.Drawing.Point(11, 9);
            this.tipo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipo1.Name = "tipo1";
            this.tipo1.Size = new System.Drawing.Size(209, 57);
            this.tipo1.TabIndex = 3;
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(13, 91);
            this.monto1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(319, 31);
            this.monto1.TabIndex = 4;
            // 
            // tipoMoneda1
            // 
            this.tipoMoneda1.Location = new System.Drawing.Point(226, 9);
            this.tipoMoneda1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoMoneda1.Name = "tipoMoneda1";
            this.tipoMoneda1.Size = new System.Drawing.Size(245, 78);
            this.tipoMoneda1.TabIndex = 5;
            // 
            // conversion1
            // 
            this.conversion1.Location = new System.Drawing.Point(11, 204);
            this.conversion1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conversion1.Name = "conversion1";
            this.conversion1.Size = new System.Drawing.Size(335, 30);
            this.conversion1.TabIndex = 6;
            this.conversion1.Load += new System.EventHandler(this.conversion1_Load);
            // 
            // tipoMoneda2
            // 
            this.tipoMoneda2.Location = new System.Drawing.Point(13, 126);
            this.tipoMoneda2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoMoneda2.Name = "tipoMoneda2";
            this.tipoMoneda2.Size = new System.Drawing.Size(247, 74);
            this.tipoMoneda2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Precio";
            // 
            // Moneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipoMoneda2);
            this.Controls.Add(this.conversion1);
            this.Controls.Add(this.tipoMoneda1);
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.tipo1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Moneda";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Size = new System.Drawing.Size(704, 331);
            this.Load += new System.EventHandler(this.Moneda_Load);
            this.Controls.SetChildIndex(this.tipo1, 0);
            this.Controls.SetChildIndex(this.monto1, 0);
            this.Controls.SetChildIndex(this.tipoMoneda1, 0);
            this.Controls.SetChildIndex(this.conversion1, 0);
            this.Controls.SetChildIndex(this.tipoMoneda2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.Tipo tipo1;
        private Monto monto1;
        private Controles.TipoMoneda tipoMoneda1;
        private Controles.Conversion conversion1;
        private Controles.TipoMoneda tipoMoneda2;
        private System.Windows.Forms.Label label1;
    }
}
