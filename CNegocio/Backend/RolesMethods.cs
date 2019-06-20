using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class RolesMethods
    {
        private ManagerRolesModel ADRolesManager;

        public RolesMethods()
        {
            ADRolesManager = new ManagerRolesModel();
        }
        public bool Crear(RolesModel aRoles)
        {
            return ADRolesManager.Insert(aRoles);
        }

        public bool Editar(RolesModel aRoles)
        {
            return ADRolesManager.Update(aRoles);
        }

        public bool Eliminar(int aID_Roles)
        {
            return ADRolesManager.Delete(aID_Roles);
        }

        public RolesModel ObtenerUno(int aID_Roles)
        {
            return ADRolesManager.GetRolesModel(aID_Roles);
        }

        public List<RolesModel> ObtenerTodos()
        {
            return ADRolesManager.RolesModelSelectAll();
        }
    }
}
