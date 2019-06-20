using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class ChequesModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Numero value.
        /// </summary>
        public int Numero
        { get; set; }

        /// <summary>
        /// Gets or sets the Fechaemision value.
        /// </summary>
        public DateTime Fechaemision
        { get; set; }

        /// <summary>
        /// Gets or sets the Fechacobro value.
        /// </summary>
        public DateTime? Fechacobro
        { get; set; }

        /// <summary>
        /// Gets or sets the Destinatario value.
        /// </summary>
        public string Destinatario
        { get; set; }

        /// <summary>
        /// Gets or sets the Monto value.
        /// </summary>
        public decimal Monto
        { get; set; }

        /// <summary>
        /// Gets or sets the Idchequera value.
        /// </summary>
        public int Idchequera
        { get; set; }

        /// <summary>
        /// Gets or sets the Estado value.
        /// </summary>
        public string Estado
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
        /// Gets or sets the Usuario_creacion value.
        /// </summary>
        public string Usuario_creacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_modificador value.
        /// </summary>
        public string Usuario_modificador
        { get; set; }


        #endregion
    }

}
