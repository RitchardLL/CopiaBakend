using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class TipoCambioModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public int Id
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha value.
        /// </summary>
        public DateTime Fecha
        { get; set; }

        /// <summary>
        /// Gets or sets the Monedaorigen value.
        /// </summary>
        public int Monedaorigen
        { get; set; }

        /// <summary>
        /// Gets or sets the Monedaobjetivo value.
        /// </summary>
        public int Monedaobjetivo
        { get; set; }

        /// <summary>
        /// Gets or sets the Montocompra value.
        /// </summary>
        public decimal Montocompra
        { get; set; }

        /// <summary>
        /// Gets or sets the Montoventa value.
        /// </summary>
        public decimal Montoventa
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_creador value.
        /// </summary>
        public string Usuario_creador
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_creacion value.
        /// </summary>
        public DateTime Fecha_creacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_modificador value.
        /// </summary>
        public string Usuario_modificador
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_modificacion value.
        /// </summary>
        public DateTime? Fecha_modificacion
        { get; set; }


        #endregion
    }

}
