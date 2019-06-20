namespace Sistema_Bancario
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Rol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BTOperaciones = new System.Windows.Forms.Button();
            this.BTReportes = new System.Windows.Forms.Button();
            this.BTGestion = new System.Windows.Forms.Button();
            this.BTManteniminetos = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.TituloText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MoveFrom = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(279, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 663);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 625);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sis Bancario";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.ForestGreen;
            this.panel5.Controls.Add(this.Rol);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(0, 84);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 71);
            this.panel5.TabIndex = 9;
            // 
            // Rol
            // 
            this.Rol.AutoSize = true;
            this.Rol.ForeColor = System.Drawing.Color.White;
            this.Rol.Location = new System.Drawing.Point(19, 43);
            this.Rol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(29, 17);
            this.Rol.TabIndex = 3;
            this.Rol.Text = "Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre y Apellido";
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button11.BackColor = System.Drawing.Color.Brown;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.Window;
            this.button11.Location = new System.Drawing.Point(0, 780);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(267, 50);
            this.button11.TabIndex = 10;
            this.button11.Text = "Cerrar Session";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.BTOperaciones);
            this.panel3.Controls.Add(this.BTReportes);
            this.panel3.Controls.Add(this.BTGestion);
            this.panel3.Controls.Add(this.BTManteniminetos);
            this.panel3.Location = new System.Drawing.Point(267, 44);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(935, 40);
            this.panel3.TabIndex = 8;
            // 
            // BTOperaciones
            // 
            this.BTOperaciones.BackColor = System.Drawing.Color.Transparent;
            this.BTOperaciones.FlatAppearance.BorderSize = 0;
            this.BTOperaciones.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.BTOperaciones.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.BTOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTOperaciones.ForeColor = System.Drawing.Color.White;
            this.BTOperaciones.Location = new System.Drawing.Point(0, 0);
            this.BTOperaciones.Margin = new System.Windows.Forms.Padding(4);
            this.BTOperaciones.Name = "BTOperaciones";
            this.BTOperaciones.Size = new System.Drawing.Size(112, 39);
            this.BTOperaciones.TabIndex = 8;
            this.BTOperaciones.Text = "Operaciones";
            this.BTOperaciones.UseVisualStyleBackColor = false;
            this.BTOperaciones.Click += new System.EventHandler(this.button12_Click);
            // 
            // BTReportes
            // 
            this.BTReportes.BackColor = System.Drawing.Color.Transparent;
            this.BTReportes.FlatAppearance.BorderSize = 0;
            this.BTReportes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.BTReportes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.BTReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTReportes.ForeColor = System.Drawing.Color.White;
            this.BTReportes.Location = new System.Drawing.Point(337, 0);
            this.BTReportes.Margin = new System.Windows.Forms.Padding(4);
            this.BTReportes.Name = "BTReportes";
            this.BTReportes.Size = new System.Drawing.Size(100, 39);
            this.BTReportes.TabIndex = 11;
            this.BTReportes.Text = "Reportes";
            this.BTReportes.UseVisualStyleBackColor = false;
            this.BTReportes.Click += new System.EventHandler(this.button15_Click);
            // 
            // BTGestion
            // 
            this.BTGestion.BackColor = System.Drawing.Color.Transparent;
            this.BTGestion.FlatAppearance.BorderSize = 0;
            this.BTGestion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.BTGestion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.BTGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTGestion.ForeColor = System.Drawing.Color.White;
            this.BTGestion.Location = new System.Drawing.Point(112, 0);
            this.BTGestion.Margin = new System.Windows.Forms.Padding(4);
            this.BTGestion.Name = "BTGestion";
            this.BTGestion.Size = new System.Drawing.Size(100, 39);
            this.BTGestion.TabIndex = 9;
            this.BTGestion.Text = "Gestion";
            this.BTGestion.UseVisualStyleBackColor = false;
            this.BTGestion.Click += new System.EventHandler(this.button13_Click);
            // 
            // BTManteniminetos
            // 
            this.BTManteniminetos.BackColor = System.Drawing.Color.Transparent;
            this.BTManteniminetos.FlatAppearance.BorderSize = 0;
            this.BTManteniminetos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.BTManteniminetos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.BTManteniminetos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTManteniminetos.ForeColor = System.Drawing.Color.White;
            this.BTManteniminetos.Location = new System.Drawing.Point(212, 0);
            this.BTManteniminetos.Margin = new System.Windows.Forms.Padding(4);
            this.BTManteniminetos.Name = "BTManteniminetos";
            this.BTManteniminetos.Size = new System.Drawing.Size(125, 39);
            this.BTManteniminetos.TabIndex = 10;
            this.BTManteniminetos.Text = "Matenimientos";
            this.BTManteniminetos.UseVisualStyleBackColor = false;
            this.BTManteniminetos.Click += new System.EventHandler(this.button14_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Window;
            this.button7.Location = new System.Drawing.Point(871, 1);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 41);
            this.button7.TabIndex = 7;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // TituloText
            // 
            this.TituloText.AutoSize = true;
            this.TituloText.BackColor = System.Drawing.Color.Transparent;
            this.TituloText.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TituloText.Location = new System.Drawing.Point(280, 99);
            this.TituloText.Name = "TituloText";
            this.TituloText.Size = new System.Drawing.Size(87, 33);
            this.TituloText.TabIndex = 6;
            this.TituloText.Text = "Titulo";
            this.TituloText.Visible = false;
            // 
            // MoveFrom
            // 
            this.MoveFrom.Fixed = true;
            this.MoveFrom.Horizontal = true;
            this.MoveFrom.TargetControl = this.panel6;
            this.MoveFrom.Vertical = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel6.Controls.Add(this.button7);
            this.panel6.Location = new System.Drawing.Point(267, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(933, 44);
            this.panel6.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 155);
            this.panel4.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1200, 829);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.TituloText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel TituloText;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button11;
        private Bunifu.Framework.UI.BunifuDragControl MoveFrom;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTReportes;
        private System.Windows.Forms.Button BTManteniminetos;
        private System.Windows.Forms.Button BTGestion;
        private System.Windows.Forms.Button BTOperaciones;
        private System.Windows.Forms.Label Rol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
    }
}