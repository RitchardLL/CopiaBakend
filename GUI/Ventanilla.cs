using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Bancario.Froms_opciones;
using Modelos.Modelos;

namespace Sistema_Bancario
{
    public partial class Form2 : Form
    {
        List<PermisosUsuarioModel> Usuario =  new List<PermisosUsuarioModel>(); 
       // public object Opciones;
        public Form2()
        {
            InitializeComponent();
           // this.cargarcomponentes(user);

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                BTGestion.BackColor = SystemColors.HotTrack;
                panel2.Controls.Clear();
                this.Componentes(3);
                return true;
            }
            else if (keyData == (Keys.F2))
            {
                BTGestion.BackColor = SystemColors.HotTrack;
                panel2.Controls.Clear();
                this.Componentes(1);
                return true;
            }
            else if (keyData == (Keys.F3))
            {
                BTGestion.BackColor = SystemColors.HotTrack;
                panel2.Controls.Clear();
                this.Componentes(1);
                return true;
            }
            else if (keyData == (Keys.F4))
            {
               
            }
                return base.ProcessCmdKey(ref msg, keyData);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        public void Limpiar()
        {
          /*  button1.BackColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
        */
        }
    
 
        public void CrearBoton(Button NombreButton,string Text,int x) {

            NombreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            NombreButton.FlatAppearance.BorderSize = 0;
            NombreButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            NombreButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            NombreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            NombreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NombreButton.ForeColor = System.Drawing.SystemColors.Window;
            //AbrirCuenta.Location = new System.Drawing.Point(26, 72);
            NombreButton.Margin = new System.Windows.Forms.Padding(2);
           // NombreButton.Name = "button6";
            NombreButton.Size = new System.Drawing.Size(200, 41);
            NombreButton.TabIndex = 6;
            NombreButton.Text = Text;
            NombreButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            NombreButton.UseVisualStyleBackColor = false;          
            NombreButton.Location = new Point(0, x);
            NombreButton.Click += new EventHandler(Evento_Click);
            panel2.Controls.Add(NombreButton);

        }

        private void Evento_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TituloText.Visible = true;
            #region 
            if (btn.Text.Equals("Retiros"))
            {
                if (!panel1.Controls.Contains(Retiros.instance))
                {
                    panel1.Controls.Add(Retiros.instance);
                    Retiros.instance.Dock = DockStyle.Fill;
                    Retiros.instance.BringToFront();
                    TituloText.Text = btn.Text;

                }
                else
                {
                    TituloText.Text = btn.Text;
                    Retiros.instance.BringToFront();
                }
                // Limpiar();
                //   button9.BackColor = SystemColors.HotTrack;
            }
            else if (btn.Text.Equals("Depositos"))
            {
                if (!panel1.Controls.Contains(Depositos.instance))
                {
                    panel1.Controls.Add(Depositos.instance);
                    Depositos.instance.Dock = DockStyle.Fill;
                    Depositos.instance.BringToFront();
                    TituloText.Text = btn.Text;
                }
                else
                {
                    TituloText.Text = btn.Text;
                    Depositos.instance.BringToFront();
                }
                //  Limpiar();
                //   button6.BackColor = SystemColors.HotTrack;

            }
            else if (btn.Text.Equals("Transferencias"))
            {
                if (!panel1.Controls.Contains(Transferencias.instance))
                {
                    panel1.Controls.Add(Transferencias.instance);
                    Transferencias.instance.Dock = DockStyle.Fill;
                    Transferencias.instance.BringToFront();
                    TituloText.Text = btn.Text;

                }
                else
                {
                    Transferencias.instance.BringToFront();
                    TituloText.Text = btn.Text;
                }
                //    Limpiar();
                //   button2.BackColor = SystemColors.HotTrack;
            }
            else if (btn.Text.Equals("Envio Giros"))
            {
                if (!panel1.Controls.Contains(Envio_Giros.instance))
                {
                    panel1.Controls.Add(Envio_Giros.instance);
                    Envio_Giros.instance.Dock = DockStyle.Fill;
                    Envio_Giros.instance.BringToFront();
                    TituloText.Text = btn.Text;
                }
                else
                {
                    Envio_Giros.instance.BringToFront();
                    TituloText.Text = btn.Text;
                }
                // Limpiar();
                //  button4.BackColor = SystemColors.HotTrack;
            }
            else if (btn.Text.Equals("Cobro Giros"))
            {
                if (!panel1.Controls.Contains(CobroGiros.instance))
                {
                    panel1.Controls.Add(CobroGiros.instance);
                    CobroGiros.instance.Dock = DockStyle.Fill;
                    CobroGiros.instance.BringToFront();
                    TituloText.Text = btn.Text;
                }
                else
                {
                    TituloText.Text = btn.Text;
                    CobroGiros.instance.BringToFront();
                }
                // Limpiar();
                //  button3.BackColor = SystemColors.HotTrack;
            }
            else if (btn.Text.Equals("Pago tarjetas"))
            {
                if (!panel1.Controls.Contains(Tarjetas.instance))
                {
                    panel1.Controls.Add(Tarjetas.instance);
                    Tarjetas.instance.Dock = DockStyle.Fill;
                    Tarjetas.instance.BringToFront();
                    TituloText.Text = btn.Text;
                }
                else
                {
                    TituloText.Text = btn.Text;
                    Tarjetas.instance.BringToFront();
                }
                //  Limpiar();
                //  button5.BackColor = SystemColors.HotTrack;
            }
            else if (btn.Text.Equals("Pago Cuotas"))
            {
                if (!panel1.Controls.Contains(Cuotas.getinstance()))
                {
                    panel1.Controls.Add(Cuotas.getinstance());
                    Cuotas.getinstance().Dock = DockStyle.Fill;
                    Cuotas.getinstance().BringToFront();
                    TituloText.Text = btn.Text;
                }
                else
                {
                    TituloText.Text = btn.Text;
                    Cuotas.getinstance().BringToFront();
                }
                //   Limpiar();
                //    button8.BackColor = SystemColors.HotTrack;
            }
            else if (btn.Text.Equals("Tipo Cambio"))
            {
                if (!panel1.Controls.Contains(Tipo_de_Cambio.instance))
                {
                    panel1.Controls.Add(Tipo_de_Cambio.instance);
                    Tipo_de_Cambio.instance.Dock = DockStyle.Fill;
                    Tipo_de_Cambio.instance.BringToFront();
                    TituloText.Text = btn.Text;

                }
                else
                {
                    Tipo_de_Cambio.instance.BringToFront();
                    TituloText.Text = btn.Text;
                }
                //  Limpiar();
                //   button1.BackColor = SystemColors.HotTrack;
            }
            else if (btn.Text.Equals("Pago Servicios"))
            {
                if (!panel1.Controls.Contains(Servicios.instance))
                {
                    panel1.Controls.Add(Servicios.instance);
                    Servicios.instance.Dock = DockStyle.Fill;
                    Servicios.instance.BringToFront();
                    TituloText.Text = btn.Text;
                }
                else
                {
                    TituloText.Text = btn.Text;
                    Servicios.instance.BringToFront();
                }

                //  Limpiar();
                // button10.BackColor = SystemColors.HotTrack;
            }
            #endregion


        }
        private void Componentes(int x)
        {
            switch (x)
            {
                case 1:
                    Button AbrirCuenta = new Button();
                    this.CrearBoton(AbrirCuenta, "Abrir Cuenta", 0);
                    Button ActualizatCuenta = new Button();
                    this.CrearBoton(ActualizatCuenta, "Actualizar Cuenta", 50);
                    Button RealizarPrestamo = new Button();
                    this.CrearBoton(RealizarPrestamo, "Relalizar Prestamo", 100);
                    Button Refinanciar = new Button();
                    this.CrearBoton(Refinanciar, "Refinanciar", 150);
                    break;
                case 2:
                    Button Cliente = new Button();
                    Button TipoCliente = new Button();
                    Button Moneda = new Button();
                    Button TipoCuenta = new Button();
                    Button InteresesMoratorios = new Button();
                    Button Aseguradora = new Button();
                    Button Empleado = new Button();

                    this.CrearBoton(Cliente, "Cliente", 0);
                    this.CrearBoton(TipoCliente, "TipoCliente", 50);
                    this.CrearBoton(TipoCuenta, "Tipo Cuenta", 100);
                    this.CrearBoton(InteresesMoratorios, "Intereses Moratorios", 150);
                    break;
                case 3:
                    Button Retiros = new Button();
                    Button Depositos = new Button();
                    Button Transferencias = new Button();
                    Button Envio_Giros = new Button();
                    Button Cobro_Giros = new Button();
                    Button Pago_tarjetas = new Button();
                    Button Pago_Cuotas = new Button();
                    Button Tipo_Cambio = new Button();
                    Button Pago_Servicios = new Button();

                    this.CrearBoton(Retiros, "Retiros", 0);
                    this.CrearBoton(Depositos, "Depositos", 50);
                    this.CrearBoton(Transferencias, "Transferencias", 100);
                    this.CrearBoton(Envio_Giros, "Envio Giros", 150);
                    this.CrearBoton(Cobro_Giros, "Cobro Giros", 200);
                    this.CrearBoton(Pago_tarjetas, "Pago tarjetas", 250);
                    this.CrearBoton(Pago_Cuotas, "Pago Cuotas", 300);
                    this.CrearBoton(Tipo_Cambio, "Tipo Cambio", 350);
                    this.CrearBoton(Pago_Servicios, "Pago Servicios", 400);
                    break;
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            BTGestion.BackColor = SystemColors.HotTrack;
            panel2.Controls.Clear();
            this.Componentes(2);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BTManteniminetos.BackColor = SystemColors.HotTrack;
            panel2.Controls.Clear();
            this.Componentes(1);


        }
        private void button12_Click(object sender, EventArgs e)
        {
            BTOperaciones.BackColor = SystemColors.HotTrack;
            panel2.Controls.Clear();
            this.Componentes(3);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            BTReportes.BackColor = SystemColors.HotTrack;
        }
    }
}
