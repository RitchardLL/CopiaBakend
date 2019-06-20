namespace Sistema_Bancario.Controles
{
    partial class Tipo
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
            this.RBCompra = new System.Windows.Forms.RadioButton();
            this.RBVenta = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RBCompra
            // 
            this.RBCompra.AutoSize = true;
            this.RBCompra.Location = new System.Drawing.Point(6, 21);
            this.RBCompra.Name = "RBCompra";
            this.RBCompra.Size = new System.Drawing.Size(78, 21);
            this.RBCompra.TabIndex = 0;
            this.RBCompra.TabStop = true;
            this.RBCompra.Text = "Compra";
            this.RBCompra.UseVisualStyleBackColor = true;
            // 
            // RBVenta
            // 
            this.RBVenta.AutoSize = true;
            this.RBVenta.Location = new System.Drawing.Point(90, 21);
            this.RBVenta.Name = "RBVenta";
            this.RBVenta.Size = new System.Drawing.Size(66, 21);
            this.RBVenta.TabIndex = 1;
            this.RBVenta.TabStop = true;
            this.RBVenta.Text = "Venta";
            this.RBVenta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBCompra);
            this.groupBox1.Controls.Add(this.RBVenta);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proceso";
            // 
            // Tipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Tipo";
            this.Size = new System.Drawing.Size(209, 56);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton RBCompra;
        public System.Windows.Forms.RadioButton RBVenta;
    }
}
