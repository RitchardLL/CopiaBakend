using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class Caja_ChicaModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public int Id
        { get; set; }

        /// <summary>
        /// Gets or sets the Tipo value.
        /// </summary>
        public string Tipo
        { get; set; }

        /// <summary>
        /// Gets or sets the Monto value.
        /// </summary>
        public decimal Monto
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_persona value.
        /// </summary>
        public int Id_persona
        { get; set; }

        /// <summary>
        /// Gets or sets the Hora value.
        /// </summary>
        public TimeSpan Hora
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha value.
        /// </summary>
        public DateTime Fecha
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_ventanilla value.
        /// </summary>
        public int Id_ventanilla
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
