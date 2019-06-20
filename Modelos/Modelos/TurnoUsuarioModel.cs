using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class TurnoUsuarioModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public int Id
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha value.
        /// </summary>
        public DateTime Fecha
        { get; set; }

        /// <summary>
        /// Gets or sets the Horainicio value.
        /// </summary>
        public TimeSpan Horainicio
        { get; set; }

        /// <summary>
        /// Gets or sets the Horafin value.
        /// </summary>
        public TimeSpan Horafin
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_usuario value.
        /// </summary>
        public int Id_usuario
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_ventanilla value.
        /// </summary>
        public int Id_ventanilla
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_horarios_atencion value.
        /// </summary>
        public int Id_horarios_atencion
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_turnos value.
        /// </summary>
        public int? Id_turnos
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