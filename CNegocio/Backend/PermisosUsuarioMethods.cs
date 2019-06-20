using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class PermisosUsuarioMethods
    {
        private ManagerPermisosUsuarioModel ADPermisosUsuarioManager;

        public PermisosUsuarioMethods()
        {
            ADPermisosUsuarioManager = new ManagerPermisosUsuarioModel();
        }
        public bool Crear(PermisosUsuarioModel aPermisosUsuario)
        {
            return ADPermisosUsuarioManager.Insert(aPermisosUsuario);
        }

        public bool Editar(PermisosUsuarioModel aPermisosUsuario)
        {
            return ADPermisosUsuarioManager.Update(aPermisosUsuario);
        }

        public bool Eliminar(int aID_PermisosUsuario)
        {
            return ADPermisosUsuarioManager.Delete(aID_PermisosUsuario);
        }

        public PermisosUsuarioModel ObtenerUno(int aID_PermisosUsuario)
        {
            return ADPermisosUsuarioManager.GetPermisosUsuarioModel(aID_PermisosUsuario);
        }

        public List<PermisosUsuarioModel> ObtenerTodos()
        {
            return ADPermisosUsuarioManager.PermisosUsuarioModelSelectAll();
        }
    }
}
