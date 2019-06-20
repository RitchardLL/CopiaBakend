namespace Sistema_Bancario.Controles
{
    partial class Clave
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
            this.LbClave = new System.Windows.Forms.Label();
            this.TBClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbClave
            // 
            this.LbClave.AutoSize = true;
            this.LbClave.Location = new System.Drawing.Point(4, 4);
            this.LbClave.Name = "LbClave";
            this.LbClave.Size = new System.Drawing.Size(43, 17);
            this.LbClave.TabIndex = 0;
            this.LbClave.Text = "Clave";
            // 
            // TBClave
            // 
            this.TBClave.Location = new System.Drawing.Point(57, 4);
            this.TBClave.Name = "TBClave";
            this.TBClave.PasswordChar = '*';
            this.TBClave.Size = new System.Drawing.Size(159, 22);
            this.TBClave.TabIndex = 1;
            // 
            // Clave
            // 
            this.Controls.Add(this.TBClave);
            this.Controls.Add(this.LbClave);
            this.Name = "Clave";
            this.Size = new System.Drawing.Size(229, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label LbClave;
        public System.Windows.Forms.TextBox TBClave;
    }
}
