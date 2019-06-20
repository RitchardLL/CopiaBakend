using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Bancario.Froms_opciones
{
    public partial class Envio_Giros : Sistema_Bancario.Base
    {
        public Envio_Giros()
        {
            InitializeComponent();
        }
        private static Envio_Giros _instance;
        public static Envio_Giros instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Envio_Giros();
                }

                return _instance;
            }
        }
    }
}
