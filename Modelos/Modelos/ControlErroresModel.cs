using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class ControlErroresModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public int Id
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario value.
        /// </summary>
        public string Usuario
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha value.
        /// </summary>
        public DateTime Fecha
        { get; set; }

        /// <summary>
        /// Gets or sets the Componente value.
        /// </summary>
        public string Componente
        { get; set; }

        /// <summary>
        /// Gets or sets the Descripcion value.
        /// </summary>
        public byte[] Descripcion
        { get; set; }


        #endregion
    }

}
