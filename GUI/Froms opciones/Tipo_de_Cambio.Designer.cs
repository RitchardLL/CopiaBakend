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
            this.tipoMoneda2 = new Sistema_Bancario.Controles.TipoMoneda();
            this.conversion2 = new Sistema_Bancario.Controles.Conversion();
            this.fecha1 = new Sistema_Bancario.Controles.Fecha();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(8, 312);
            this.proceder1.Size = new System.Drawing.Size(664, 49);
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
            this.monto1.Location = new System.Drawing.Point(7, 85);
            this.monto1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(319, 31);
            this.monto1.TabIndex = 4;
            // 
            // tipoMoneda1
            // 
            this.tipoMoneda1.Location = new System.Drawing.Point(332, 85);
            this.tipoMoneda1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoMoneda1.Name = "tipoMoneda1";
            this.tipoMoneda1.Size = new System.Drawing.Size(325, 35);
            this.tipoMoneda1.TabIndex = 5;
            // 
            // tipoMoneda2
            // 
            this.tipoMoneda2.Location = new System.Drawing.Point(332, 124);
            this.tipoMoneda2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoMoneda2.Name = "tipoMoneda2";
            this.tipoMoneda2.Size = new System.Drawing.Size(333, 30);
            this.tipoMoneda2.TabIndex = 7;
            // 
            // conversion2
            // 
            this.conversion2.Location = new System.Drawing.Point(7, 124);
            this.conversion2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conversion2.Name = "conversion2";
            this.conversion2.Size = new System.Drawing.Size(298, 30);
            this.conversion2.TabIndex = 10;
            // 
            // fecha1
            // 
            this.fecha1.Location = new System.Drawing.Point(457, 21);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(204, 35);
            this.fecha1.TabIndex = 11;
            // 
            // Tipo_de_Cambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.conversion2);
            this.Controls.Add(this.tipoMoneda2);
            this.Controls.Add(this.tipoMoneda1);
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.tipo1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tipo_de_Cambio";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Size = new System.Drawing.Size(680, 368);
            this.Controls.SetChildIndex(this.tipo1, 0);
            this.Controls.SetChildIndex(this.monto1, 0);
            this.Controls.SetChildIndex(this.tipoMoneda1, 0);
            this.Controls.SetChildIndex(this.tipoMoneda2, 0);
            this.Controls.SetChildIndex(this.conversion2, 0);
            this.Controls.SetChildIndex(this.fecha1, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.Tipo tipo1;
        private Monto monto1;
        private Controles.TipoMoneda tipoMoneda1;
        private Controles.TipoMoneda tipoMoneda2;
        private Controles.Conversion conversion2;
        private Controles.Fecha fecha1;
    }
}
