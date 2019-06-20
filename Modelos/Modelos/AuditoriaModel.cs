using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class AuditoriaModel
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
        /// Gets or sets the Nombretabla value.
        /// </summary>
        public string Nombretabla
        { get; set; }

        /// <summary>
        /// Gets or sets the Operacion value.
        /// </summary>
        public string Operacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Tsql value.
        /// </summary>
        public string Tsql
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha value.
        /// </summary>
        public DateTime Fecha
        { get; set; }

        /// <summary>
        /// Gets or sets the Campoorigendestino value.
        /// </summary>
        //public UNKNOWN_xml Campoorigendestino
        //{ get; set; }


        #endregion
    }

}
