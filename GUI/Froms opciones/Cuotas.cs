using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Bancario
{
    public partial class Cuotas : Base
    {
        public Cuotas()
        {
            InitializeComponent();

        }
        private static Cuotas _instance;

        public static Cuotas getinstance()
        {
            if (_instance == null)
            {
                _instance = new Cuotas();
            }

            return _instance;
        }
    }
}
