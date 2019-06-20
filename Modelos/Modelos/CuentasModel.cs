using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class CuentasModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Nrocuenta value.
        /// </summary>
        public string Nrocuenta
        { get; set; }

        /// <summary>
        /// Gets or sets the Estado value.
        /// </summary>
        public bool Estado
        { get; set; }

        /// <summary>
        /// Gets or sets the Saldocontable value.
        /// </summary>
        public decimal Saldocontable
        { get; set; }

        /// <summary>
        /// Gets or sets the Saldodisponible value.
        /// </summary>
        public decimal Saldodisponible
        { get; set; }

        /// <summary>
        /// Gets or sets the Sobregiro value.
        /// </summary>
        public decimal Sobregiro
        { get; set; }

        /// <summary>
        /// Gets or sets the Tipocuenta value.
        /// </summary>
        public string Tipocuenta
        { get; set; }

        /// <summary>
        /// Gets or sets the Tipomoneda value.
        /// </summary>
        public short Tipomoneda
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_tarjeta value.
        /// </summary>
        public int? Id_tarjeta
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_creador value.
        /// </summary>
        public string Usuario_creador
        { get; set; }

        /// <summary>
        /// Gets or sets the Cliente value.
        /// </summary>
        public int Cliente
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_creacion value.
        /// </summary>
        public DateTime Fecha_creacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_modificacion value.
        /// </summary>
        public DateTime? Fecha_modificacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_modificador value.
        /// </summary>
        public string Usuario_modificador
        { get; set; }


        #endregion
    }

}
