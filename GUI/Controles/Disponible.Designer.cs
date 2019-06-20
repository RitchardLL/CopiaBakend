namespace Sistema_Bancario.Controles
{
    partial class Disponible
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbDisponible = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado";
            // 
            // TbDisponible
            // 
            this.TbDisponible.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TbDisponible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDisponible.Enabled = false;
            this.TbDisponible.HideSelection = false;
            this.TbDisponible.Location = new System.Drawing.Point(71, 5);
            this.TbDisponible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbDisponible.Name = "TbDisponible";
            this.TbDisponible.Size = new System.Drawing.Size(124, 22);
            this.TbDisponible.TabIndex = 1;
            this.TbDisponible.Tag = "Estado";
            this.TbDisponible.Text = "Estado";
            // 
            // Disponible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TbDisponible);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Disponible";
            this.Size = new System.Drawing.Size(219, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TbDisponible;
    }
}
