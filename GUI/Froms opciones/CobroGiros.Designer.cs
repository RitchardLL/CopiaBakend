namespace Sistema_Bancario.Froms_opciones
{
    partial class CobroGiros
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
            this.dni1 = new Sistema_Bancario.Dni();
            this.clave1 = new Sistema_Bancario.Controles.Clave();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(8, 313);
            this.proceder1.Size = new System.Drawing.Size(653, 49);
            // 
            // dni1
            // 
            this.dni1.Location = new System.Drawing.Point(29, 14);
            this.dni1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dni1.Name = "dni1";
            this.dni1.Size = new System.Drawing.Size(232, 33);
            this.dni1.TabIndex = 2;
            // 
            // clave1
            // 
            this.clave1.Location = new System.Drawing.Point(29, 51);
            this.clave1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clave1.Name = "clave1";
            this.clave1.Size = new System.Drawing.Size(397, 32);
            this.clave1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(629, 157);
            this.dataGridView1.TabIndex = 4;
            // 
            // CobroGiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clave1);
            this.Controls.Add(this.dni1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CobroGiros";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Size = new System.Drawing.Size(669, 369);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.dni1, 0);
            this.Controls.SetChildIndex(this.clave1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Dni dni1;
        private Controles.Clave clave1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
