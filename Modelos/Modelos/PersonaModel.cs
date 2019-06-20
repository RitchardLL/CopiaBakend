using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class PersonaModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public int Id
        { get; set; }

        /// <summary>
        /// Gets or sets the Nombreusuario value.
        /// </summary>
        public string Nombreusuario
        { get; set; }

        /// <summary>
        /// Gets or sets the Pass value.
        /// </summary>
        public string Pass
        { get; set; }

        /// <summary>
        /// Gets or sets the Correo value.
        /// </summary>
        public string Correo
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha value.
        /// </summary>
        public DateTime? Fecha
        { get; set; }

        /// <summary>
        /// Gets or sets the Estado value.
        /// </summary>
        public bool Estado
        { get; set; }

        /// <summary>
        /// Gets or sets the Nombres value.
        /// </summary>
        public string Nombres
        { get; set; }

        /// <summary>
        /// Gets or sets the Apellidos value.
        /// </summary>
        public string Apellidos
        { get; set; }

        /// <summary>
        /// Gets or sets the Fechanacimiento value.
        /// </summary>
        public DateTime Fechanacimiento
        { get; set; }

        /// <summary>
        /// Gets or sets the Telefono value.
        /// </summary>
        public string Telefono
        { get; set; }

        /// <summary>
        /// Gets or sets the Nrodocumento value.
        /// </summary>
        public string Nrodocumento
        { get; set; }

        /// <summary>
        /// Gets or sets the Tipodocumento value.
        /// </summary>
        public int Tipodocumento
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
        /// Gets or sets the Usuario_creador value.
        /// </summary>
        public string Usuario_creador
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_modificador value.
        /// </summary>
        public string Usuario_modificador
        { get; set; }


        #endregion
    }

}
