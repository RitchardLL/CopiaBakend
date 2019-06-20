namespace Sistema_Bancario
{
    partial class Cuotas
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
            this.nro_Documento1 = new Sistema_Bancario.Nro_Documento();
            this.BTBuscarCuota = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BTFiltrarCuotas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // nro_Documento1
            // 
            this.nro_Documento1.Location = new System.Drawing.Point(11, 14);
            this.nro_Documento1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nro_Documento1.Name = "nro_Documento1";
            this.nro_Documento1.Size = new System.Drawing.Size(445, 32);
            this.nro_Documento1.TabIndex = 3;
            // 
            // BTBuscarCuota
            // 
            this.BTBuscarCuota.BackColor = System.Drawing.Color.ForestGreen;
            this.BTBuscarCuota.FlatAppearance.BorderSize = 0;
            this.BTBuscarCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBuscarCuota.ForeColor = System.Drawing.Color.White;
            this.BTBuscarCuota.Location = new System.Drawing.Point(462, 14);
            this.BTBuscarCuota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTBuscarCuota.Name = "BTBuscarCuota";
            this.BTBuscarCuota.Size = new System.Drawing.Size(75, 32);
            this.BTBuscarCuota.TabIndex = 4;
            this.BTBuscarCuota.Text = "Buscar";
            this.BTBuscarCuota.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 87);
            this.dataGridView1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nro Prestamo";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(11, 184);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(648, 262);
            this.dataGridView2.TabIndex = 8;
            // 
            // BTFiltrarCuotas
            // 
            this.BTFiltrarCuotas.BackColor = System.Drawing.Color.ForestGreen;
            this.BTFiltrarCuotas.FlatAppearance.BorderSize = 0;
            this.BTFiltrarCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTFiltrarCuotas.ForeColor = System.Drawing.Color.White;
            this.BTFiltrarCuotas.Location = new System.Drawing.Point(267, 50);
            this.BTFiltrarCuotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTFiltrarCuotas.Name = "BTFiltrarCuotas";
            this.BTFiltrarCuotas.Size = new System.Drawing.Size(75, 32);
            this.BTFiltrarCuotas.TabIndex = 9;
            this.BTFiltrarCuotas.Text = "Filtrar";
            this.BTFiltrarCuotas.UseVisualStyleBackColor = false;
            // 
            // Cuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.BTFiltrarCuotas);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTBuscarCuota);
            this.Controls.Add(this.nro_Documento1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cuotas";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Size = new System.Drawing.Size(679, 534);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Nro_Documento nro_Documento1;
        private System.Windows.Forms.Button BTBuscarCuota;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BTFiltrarCuotas;
    }
}
