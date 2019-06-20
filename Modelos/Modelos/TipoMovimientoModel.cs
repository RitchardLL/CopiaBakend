using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modelos.Modelos
{
    public class TipoMovimientoModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Id_tipomovimiento value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Id_tipomovimiento")]
        public int Id_tipomovimiento
        { get; set; }

        /// <summary>
        /// Gets or sets the Descripcion value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Descripcion")]
        public string Descripcion
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_creador value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Usuario_creador")]
        public string Usuario_creador
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_creacion value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Fecha_creacion")]
        public DateTime Fecha_creacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_modificador value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Usuario_modificador")]
        public string Usuario_modificador
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_modificacion value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Fecha_modificacion")]
        public DateTime? Fecha_modificacion
        { get; set; }


        #endregion
    }

}
