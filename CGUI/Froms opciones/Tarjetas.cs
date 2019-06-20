using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Bancario.Froms_opciones
{
    public partial class Tarjetas : Sistema_Bancario.Base
    {
        public Tarjetas()
        {
            InitializeComponent();
        }
        private static Tarjetas _instance;
        public static Tarjetas instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Tarjetas();
                }

                return _instance;
            }
        }

    }
}
