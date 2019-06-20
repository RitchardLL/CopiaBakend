namespace Sistema_Bancario
{
    partial class Dni
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
            this.DOY = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DOY
            // 
            this.DOY.AutoSize = true;
            this.DOY.Location = new System.Drawing.Point(2, 6);
            this.DOY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DOY.Name = "DOY";
            this.DOY.Size = new System.Drawing.Size(26, 13);
            this.DOY.TabIndex = 0;
            this.DOY.Text = "DOI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 3);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Dni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DOY);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dni";
            this.Size = new System.Drawing.Size(170, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DOY;
        private System.Windows.Forms.TextBox textBox1;
    }
}
