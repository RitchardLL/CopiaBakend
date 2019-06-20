using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class ChequerasModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Numero value.
        /// </summary>
        public int Numero
        { get; set; }

        /// <summary>
        /// Gets or sets the Estado value.
        /// </summary>
        public string Estado
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecharegistro value.
        /// </summary>
        public DateTime? Fecharegistro
        { get; set; }

        /// <summary>
        /// Gets or sets the Inicio value.
        /// </summary>
        public byte Inicio
        { get; set; }

        /// <summary>
        /// Gets or sets the Fin value.
        /// </summary>
        public byte Fin
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_cuenta value.
        /// </summary>
        public string Id_cuenta
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_modificacion value.
        /// </summary>
        public DateTime? Fecha_modificacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_creador value.
        /// </summary>
        public string Usuario_creador
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_modificador value.
        /// </summary>
        public string Usuario_modificador
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_creacion value.
        /// </summary>
        public DateTime Fecha_creacion
        { get; set; }


        #endregion
    }

}
