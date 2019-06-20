using Modelos.Modelos;
using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Backend
{
    interface IPermisosUsuarioService
    {
        [OperationContract]
        bool PermisosUsuario_Crear(PermisosUsuarioModel aPermisosUsuario);

        [OperationContract]
        bool PermisosUsuario_Editar(PermisosUsuarioModel aPermisosUsuario);

        [OperationContract]
        bool PermisosUsuario_Eliminar(int aID_PermisosUsuario);

        [OperationContract]
        PermisosUsuarioModel PermisosUsuario_ObtenerUno(int aID_PermisosUsuario);

        [OperationContract]
        List<PermisosUsuarioModel> PermisosUsuario_ObtenerTodos();
    }
}
