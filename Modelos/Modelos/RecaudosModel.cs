using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modelos.Modelos
{
    public class RecaudosModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Nro_contrato value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Nro_contrato")]
        public int Nro_contrato
        { get; set; }

        /// <summary>
        /// Gets or sets the Monto value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Monto")]
        public decimal Monto
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_vencimiento value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Fecha_vencimiento")]
        public DateTime Fecha_vencimiento
        { get; set; }

        /// <summary>
        /// Gets or sets the Estado_recaudo value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Estado_recaudo")]
        public bool Estado_recaudo
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_empresa value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Id_empresa")]
        public int Id_empresa
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
        /// Gets or sets the Usuario_modificador value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Usuario_modificador")]
        public string Usuario_modificador
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_creador value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Usuario_creador")]
        public string Usuario_creador
        { get; set; }


        #endregion
    }

}
