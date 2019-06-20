using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modelos.Modelos
{
    public class CobroChequesModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Id_cheque value.
        /// </summary>
       [XmlElement(ElementName = "Id_cheque")]
        public int Id_cheque
        { get; set; }

        /// <summary>
        /// Gets or sets the Monto value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Monto")]
        public decimal Monto
        { get; set; }

        /// <summary>
        /// Gets or sets the Estado_cheque value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Estado_cheque")]
        public bool Estado_cheque
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_movimiento value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Id_movimiento")]
        public int Id_movimiento
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_creacion value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Fecha_creacion")]
        public DateTime Fecha_creacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_modificacion value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Fecha_modificacion")]
        public DateTime? Fecha_modificacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_creador value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Usuario_creador")]
        public string Usuario_creador
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_modificador value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Usuario_modificador")]
        public string Usuario_modificador
        { get; set; }


        #endregion
    }

}
