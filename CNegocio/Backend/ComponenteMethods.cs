using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class ComponenteMethods
    {
        private ManagerComponenteModel ADComponenteManager;

        public ComponenteMethods()
        {
            ADComponenteManager = new ManagerComponenteModel();
        }
        public bool Crear(ComponenteModel aComponente)
        {
            return ADComponenteManager.Insert(aComponente);
        }

        public bool Editar(ComponenteModel aComponente)
        {
            return ADComponenteManager.Update(aComponente);
        }

        public bool Eliminar(int aID_Componente)
        {
            return ADComponenteManager.Delete(aID_Componente);
        }

        public ComponenteModel ObtenerUno(int aID_Componente)
        {
            return ADComponenteManager.GetComponenteModel(aID_Componente);
        }

        public List<ComponenteModel> ObtenerTodos()
        {
            return ADComponenteManager.ComponenteModelSelectAll();
        }

    }
}
