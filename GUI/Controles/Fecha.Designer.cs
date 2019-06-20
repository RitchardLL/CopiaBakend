namespace Sistema_Bancario.Controles
{
    partial class Fecha
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
            this.DtFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // DtFecha
            // 
            this.DtFecha.Location = new System.Drawing.Point(0, 3);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(200, 22);
            this.DtFecha.TabIndex = 0;
            // 
            // Fecha
            // 
            this.Controls.Add(this.DtFecha);
            this.Name = "Fecha";
            this.Size = new System.Drawing.Size(211, 35);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DateTimePicker DtFecha;
    }
}
