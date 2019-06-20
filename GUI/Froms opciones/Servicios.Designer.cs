namespace Sistema_Bancario.Froms_opciones
{
    partial class Servicios
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
            this.empresa1 = new Sistema_Bancario.Controles.Empresa();
            this.nroContrato1 = new Sistema_Bancario.Controles.NroContrato();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BTBuscarEmpresa = new System.Windows.Forms.Button();
            this.BTNroContrato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // empresa1
            // 
            this.empresa1.Location = new System.Drawing.Point(13, 14);
            this.empresa1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empresa1.Name = "empresa1";
            this.empresa1.Size = new System.Drawing.Size(348, 32);
            this.empresa1.TabIndex = 3;
            // 
            // nroContrato1
            // 
            this.nroContrato1.Location = new System.Drawing.Point(13, 178);
            this.nroContrato1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nroContrato1.Name = "nroContrato1";
            this.nroContrato1.Size = new System.Drawing.Size(364, 34);
            this.nroContrato1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(647, 121);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 218);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(647, 142);
            this.dataGridView2.TabIndex = 6;
            // 
            // BTBuscarEmpresa
            // 
            this.BTBuscarEmpresa.Location = new System.Drawing.Point(368, 14);
            this.BTBuscarEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTBuscarEmpresa.Name = "BTBuscarEmpresa";
            this.BTBuscarEmpresa.Size = new System.Drawing.Size(117, 31);
            this.BTBuscarEmpresa.TabIndex = 7;
            this.BTBuscarEmpresa.Text = "Buscar";
            this.BTBuscarEmpresa.UseVisualStyleBackColor = true;
            this.BTBuscarEmpresa.Click += new System.EventHandler(this.BTBuscarEmpresa_Click);
            // 
            // BTNroContrato
            // 
            this.BTNroContrato.Location = new System.Drawing.Point(383, 178);
            this.BTNroContrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNroContrato.Name = "BTNroContrato";
            this.BTNroContrato.Size = new System.Drawing.Size(117, 34);
            this.BTNroContrato.TabIndex = 8;
            this.BTNroContrato.Text = "Buscar";
            this.BTNroContrato.UseVisualStyleBackColor = true;
            this.BTNroContrato.Click += new System.EventHandler(this.BTNroContrato_Click);
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.BTNroContrato);
            this.Controls.Add(this.BTBuscarEmpresa);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nroContrato1);
            this.Controls.Add(this.empresa1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Servicios";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Size = new System.Drawing.Size(688, 433);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.Empresa empresa1;
        private Controles.NroContrato nroContrato1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BTBuscarEmpresa;
        private System.Windows.Forms.Button BTNroContrato;
    }
}
