using Modelos.Modelos;
using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Backend
{
    interface ITurnoUsuarioService
    {
        [OperationContract]
        bool TurnoUsuario_Crear(TurnoUsuarioModel aTurnoUsuario);

        [OperationContract]
        bool TurnoUsuario_Editar(TurnoUsuarioModel aTurnoUsuario);

        [OperationContract]
        bool TurnoUsuario_Eliminar(int aID_TurnoUsuario);

        [OperationContract]
        TurnoUsuarioModel TurnoUsuario_ObtenerUno(int aID_TurnoUsuario);

        [OperationContract]
        List<TurnoUsuarioModel> TurnoUsuario_ObtenerTodos();
    }
}