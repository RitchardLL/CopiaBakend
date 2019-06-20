using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Bancario.Froms_opciones
{
    public partial class Tipo_de_Cambio : Sistema_Bancario.Base
    {
        
        public Tipo_de_Cambio()
        {
            InitializeComponent();
        }
        private static Tipo_de_Cambio _instance;
        public static Tipo_de_Cambio instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Tipo_de_Cambio();
                }

                return _instance;
            }
        }

        private void Moneda_Load(object sender, EventArgs e)
        {

        }

        private void conversion1_Load(object sender, EventArgs e)
        {

        }
    }
}
