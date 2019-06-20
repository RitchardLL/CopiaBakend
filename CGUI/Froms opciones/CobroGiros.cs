using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Bancario.Froms_opciones
{
    public partial class CobroGiros : Sistema_Bancario.Base
    {
        public CobroGiros()
        {
            InitializeComponent();
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
