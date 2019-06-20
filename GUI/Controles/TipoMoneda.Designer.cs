namespace Sistema_Bancario.Controles
{
    partial class TipoMoneda
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
            this.CboMoneda = new System.Windows.Forms.ComboBox();
            this.LbMoneda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CboMoneda
            // 
            this.CboMoneda.FormattingEnabled = true;
            this.CboMoneda.Items.AddRange(new object[] {
            "Soles",
            "Dolares",
            "Euros"});
            this.CboMoneda.Location = new System.Drawing.Point(68, 3);
            this.CboMoneda.Name = "CboMoneda";
            this.CboMoneda.Size = new System.Drawing.Size(232, 24);
            this.CboMoneda.TabIndex = 4;
            // 
            // LbMoneda
            // 
            this.LbMoneda.AutoSize = true;
            this.LbMoneda.Location = new System.Drawing.Point(3, 6);
            this.LbMoneda.Name = "LbMoneda";
            this.LbMoneda.Size = new System.Drawing.Size(59, 17);
            this.LbMoneda.TabIndex = 5;
            this.LbMoneda.Text = "Moneda";
            // 
            // TipoMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbMoneda);
            this.Controls.Add(this.CboMoneda);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TipoMoneda";
            this.Size = new System.Drawing.Size(328, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox CboMoneda;
        private System.Windows.Forms.Label LbMoneda;
    }
}
