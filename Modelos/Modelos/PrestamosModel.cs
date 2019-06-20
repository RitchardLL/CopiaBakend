using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class PrestamosModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public int Id
        { get; set; }

        /// <summary>
        /// Gets or sets the Fechaprestamo value.
        /// </summary>
        public DateTime Fechaprestamo
        { get; set; }

        /// <summary>
        /// Gets or sets the Montoprestamo value.
        /// </summary>
        public decimal Montoprestamo
        { get; set; }

        /// <summary>
        /// Gets or sets the Moneda value.
        /// </summary>
        public short Moneda
        { get; set; }

        /// <summary>
        /// Gets or sets the Plazomeses value.
        /// </summary>
        public short Plazomeses
        { get; set; }

        /// <summary>
        /// Gets or sets the Porcentaje_interes value.
        /// </summary>
        public decimal Porcentaje_interes
        { get; set; }

        /// <summary>
        /// Gets or sets the Seguro value.
        /// </summary>
        public int Seguro
        { get; set; }

        /// <summary>
        /// Gets or sets the Cuenta value.
        /// </summary>
        public string Cuenta
        { get; set; }

        /// <summary>
        /// Gets or sets the Interes_moratorio value.
        /// </summary>
        public decimal? Interes_moratorio
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_modificacion value.
        /// </summary>
        public DateTime? Fecha_modificacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_creador value.
        /// </summary>
        public int? Usuario_creador
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_modificador value.
        /// </summary>
        public int? Usuario_modificador
        { get; set; }


        #endregion
    }

}
