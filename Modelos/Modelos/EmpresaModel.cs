using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modelos.Modelos
{
    public class EmpresaModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Id_empresa value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Id_empresa")]
        public int Id_empresa
        { get; set; }

        /// <summary>
        /// Gets or sets the Nombre_empresa value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Nombre_empresa")]
        public string Nombre_empresa
        { get; set; }

        /// <summary>
        /// Gets or sets the Descripcion value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Descripcion")]
        public string Descripcion
        { get; set; }

        /// <summary>
        /// Gets or sets the Nro_cuenta value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Nro_cuenta")]
        public string Nro_cuenta
        { get; set; }

        /// <summary>
        /// Gets or sets the Comisiones value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Comisiones")]
        public decimal Comisiones
        { get; set; }

        /// <summary>
        /// Gets or sets the Empresa_asume_comision value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Empresa_asume_comision")]
        public bool Empresa_asume_comision
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
