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
            // dni1
            // 
            this.dni1.Location = new System.Drawing.Point(22, 11);
            this.dni1.Margin = new System.Windows.Forms.Padding(2);
            this.dni1.Name = "dni1";
            this.dni1.Size = new System.Drawing.Size(174, 27);
            this.dni1.TabIndex = 2;
            // 
            // clave1
            // 
            this.clave1.Location = new System.Drawing.Point(22, 43);
            this.clave1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clave1.Name = "clave1";
            this.clave1.Size = new System.Drawing.Size(298, 28);
            this.clave1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(472, 122);
            this.dataGridView1.TabIndex = 4;
            // 
            // CobroGiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clave1);
            this.Controls.Add(this.dni1);
            this.Name = "CobroGiros";
            this.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Size = new System.Drawing.Size(503, 257);
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
