using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
    public class EmpresaMethods
    {
        private ManagerEmpresaModel ADEmpresaManager;

        public EmpresaMethods()
        {
            ADEmpresaManager = new ManagerEmpresaModel();
        }
        public bool Crear(EmpresaModel aEmpresaModel)
        {
            return ADEmpresaManager.Insert(aEmpresaModel);
        }

        public bool Editar(EmpresaModel aEmpresaModel)
        {
            return ADEmpresaManager.Update(aEmpresaModel);
        }

        public bool Eliminar(int aID_EmpresaModel)
        {
            return ADEmpresaManager.Delete(aID_EmpresaModel);
        }

        public EmpresaModel ObtenerUno(int aID_EmpresaModel)
        {
            return ADEmpresaManager.GetEmpresaModel(aID_EmpresaModel);
        }

        public List<EmpresaModel> ObtenerTodos()
        {
            return ADEmpresaManager.EmpresaModelSelectAll();
        }
    }
}
