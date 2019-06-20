using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Bancario.Froms_opciones
{
    public partial class CobroGiros :Base
    {
        public CobroGiros()
        {
            InitializeComponent();
            proceder1.BTProceder.Click += BTProceder_Click;
        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cobro Giros");
        }

        private static CobroGiros _instance;
        public static CobroGiros instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CobroGiros();
                }

                return _instance;
            }
        }
    }
}
