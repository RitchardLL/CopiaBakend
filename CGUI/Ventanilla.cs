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

namespace Sistema_Bancario
{
    public partial class Form2 : Form
    {
      //  List<Componentes>   
        public Form2()
        {
            InitializeComponent();
           // this.cargarcomponentes(user);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Tipo_de_Cambio.instance))
            {
                panel1.Controls.Add(Tipo_de_Cambio.instance);
                Tipo_de_Cambio.instance.Dock = DockStyle.Fill;
                Tipo_de_Cambio.instance.BringToFront();
                LabText.Text = Tipo_de_Cambio.instance.Name;
                
            }
            else
            {
                Tipo_de_Cambio.instance.BringToFront();
                LabText.Text = Tipo_de_Cambio.instance.Name;
            }
            Limpiar();
            button1.BackColor = SystemColors.HotTrack;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Transferencias.instance))
            {
                panel1.Controls.Add(Transferencias.instance);
                Transferencias.instance.Dock = DockStyle.Fill;
                Transferencias.instance.BringToFront();
                LabText.Text = Transferencias.instance.Name;
                
            }
            else {
                Transferencias.instance.BringToFront();
                LabText.Text = Transferencias.instance.Name;
            }
            Limpiar();
            button2.BackColor = SystemColors.HotTrack;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(CobroGiros.instance))
            {
                panel1.Controls.Add(CobroGiros.instance);
                CobroGiros.instance.Dock = DockStyle.Fill;
                CobroGiros.instance.BringToFront();
               
            }
            else {
                LabText.Text = CobroGiros.instance.Name;
                CobroGiros.instance.BringToFront();
            }
            Limpiar();
            button3.BackColor = SystemColors.HotTrack;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Envio_Giros.instance))
            {
                panel1.Controls.Add(Envio_Giros.instance);
                Envio_Giros.instance.Dock = DockStyle.Fill;
                Envio_Giros.instance.BringToFront();
               
            }
            else
            {
                Envio_Giros.instance.BringToFront();
                LabText.Text = Envio_Giros.instance.Name;
            }
            Limpiar();
            button4.BackColor = SystemColors.HotTrack;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Tarjetas.instance))
            {
                panel1.Controls.Add(Tarjetas.instance);
                Tarjetas.instance.Dock = DockStyle.Fill;
                Tarjetas.instance.BringToFront();
                            
            }
            else
            {
                LabText.Text = Tarjetas.instance.Name;
                Tarjetas.instance.BringToFront();
            }
            Limpiar();
            button5.BackColor = SystemColors.HotTrack;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Depositos.instance))
            {
                panel1.Controls.Add(Depositos.instance);
                Depositos.instance.Dock = DockStyle.Fill;
                Depositos.instance.BringToFront();
               
            }
            else
            {
                LabText.Text = Depositos.instance.Name;
                Depositos.instance.BringToFront();
            }
            Limpiar();
            button6.BackColor = SystemColors.HotTrack;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Cuotas.instance))
            {
                panel1.Controls.Add(Cuotas.instance);
                Cuotas.instance.Dock = DockStyle.Fill;
                Cuotas.instance.BringToFront();
              
            }
            else
            {
                LabText.Text = Cuotas.instance.Name;
                Cuotas.instance.BringToFront();
            }
            Limpiar();
            button8.BackColor = SystemColors.HotTrack;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Retiros.instance))
            {
                panel1.Controls.Add(Retiros.instance);
                Retiros.instance.Dock = DockStyle.Fill;
                Retiros.instance.BringToFront();
              

            }
            else
            {
                LabText.Text = Retiros.instance.Name;
                Retiros.instance.BringToFront();
            }
            Limpiar();
            button9.BackColor = SystemColors.HotTrack;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Servicios.instance))
            {
                panel1.Controls.Add(Servicios.instance);
                Servicios.instance.Dock = DockStyle.Fill;
                Servicios.instance.BringToFront();
               
            }
            else
            {
                LabText.Text = Servicios.instance.Name;
                Servicios.instance.BringToFront();
            }
        
            Limpiar();
            button10.BackColor = SystemColors.HotTrack;
        }
        public void Limpiar()
        {
            button1.BackColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void proceder1_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button AbrirCuenta  = new Button();
            Button ActualizatCuenta = new Button();
            Button RealizarPrestamo = new Button();
            Button Refinanciar = new Button();

            AbrirCuenta.Text = "Prueba";
            ActualizatCuenta.Text = "Prueba";
            RealizarPrestamo.Text = "Prueba";
            Refinanciar.Text = "Prueba";

            AbrirCuenta.Location = new Point(25, 200);
            ActualizatCuenta.Location = new Point(25, 210);
            RealizarPrestamo.Location = new Point(25, 220);
            Refinanciar.Location = new Point(25, 240);
            panel2.Controls.Add(AbrirCuenta);
            panel2.Controls.Add(ActualizatCuenta);
            panel2.Controls.Add(RealizarPrestamo);
            panel2.Controls.Add(Refinanciar);

            Button button = new Button();
            button.Text = "button text";
           
            button.Width = 100;
            button.Height = 30;
        
            panel1.Controls.Add(button);


         



        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button Cliente = new Button();
            Button TipoCliente = new Button();
            Button Moneda = new Button();
            Button TipoCuenta = new Button();
            Button InteresesMoratorios = new Button();
            Button Aseguradora = new Button();
            Button Empleado = new Button();

        }
    }
}
