using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelos.Modelos;

namespace Sistema_Bancario.Froms_opciones
{
    public partial class Tipo_de_Cambio : Base
    {
        private TipoCambioModel gTipoCambioModel;
        private string gUsuario;

        public Tipo_de_Cambio()
        {
            InitializeComponent();
            this.proceder1.BTProceder.Click += BTProceder_Click;
            this.gUsuario = "Usuario";

        
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


        private void BTProceder_Click(object sender, EventArgs e)
        {
            int id_moneda_origen = (int)this.tipoMoneda1.CboMoneda.SelectedValue;
            int id_moneda_destino = (int)this.tipoMoneda2.CboMoneda.SelectedValue;
            DateTime fecha_cambio = fecha1.DtFecha.Value.Date;
            decimal monto_compra = Convert.ToDecimal(this.monto1.TBMonto.Text);
            decimal monto_venta = Convert.ToDecimal(this.conversion2.TBConversion.Text);

            if (id_moneda_origen == id_moneda_destino)
            {
                MessageBox.Show("no tiene sentido esa conversion");
                return;
            }

            this.gTipoCambioModel = new TipoCambioModel()
            {
                Montocompra = monto_compra,
                Montoventa = monto_venta,
                Usuario_creador = this.gUsuario,
                Fecha = fecha_cambio.Date,
                Monedaorigen = id_moneda_origen,
                Monedaobjetivo = id_moneda_destino,
            };
        }
    }
}
