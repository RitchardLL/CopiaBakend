using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class RolUsuarioMethods
    {
        private ManagerRolUsuarioModel ADRolUsuarioManager;

        public RolUsuarioMethods()
        {
            ADRolUsuarioManager = new ManagerRolUsuarioModel();
        }
        public bool Crear(RolUsuarioModel aRolUsuario)
        {
            return ADRolUsuarioManager.Insert(aRolUsuario);
        }

        public bool Editar(RolUsuarioModel aRolUsuario)
        {
            return ADRolUsuarioManager.Update(aRolUsuario);
        }

        public bool Eliminar(int aID_RolUsuario)
        {
            return ADRolUsuarioManager.Delete(aID_RolUsuario);
        }

        public RolUsuarioModel ObtenerUno(int aID_RolUsuario)
        {
            return ADRolUsuarioManager.GetRolUsuarioModel(aID_RolUsuario);
        }

        public List<RolUsuarioModel> ObtenerTodos()
        {
            return ADRolUsuarioManager.RolUsuarioModelSelectAll();
        }
    }
}
