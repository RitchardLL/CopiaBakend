using System.Windows.Forms;

namespace Sistema_Bancario.Controles
{
    partial class Proceder
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
            this.BTProceder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTProceder
            // 
            this.BTProceder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTProceder.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTProceder.FlatAppearance.BorderSize = 0;
            this.BTProceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.BTProceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.BTProceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTProceder.ForeColor = System.Drawing.SystemColors.Window;
            this.BTProceder.Location = new System.Drawing.Point(0, 0);
            this.BTProceder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTProceder.Name = "BTProceder";
            this.BTProceder.Size = new System.Drawing.Size(148, 49);
            this.BTProceder.TabIndex = 0;
            this.BTProceder.Text = "Proceder";
            this.BTProceder.UseVisualStyleBackColor = false;
            this.BTProceder.Click += new System.EventHandler(this.button1_Click);
            // 
            // Proceder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTProceder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Proceder";
            this.Size = new System.Drawing.Size(148, 49);
            this.ResumeLayout(false);

        }

        #endregion

        public Button BTProceder;
    }
}
