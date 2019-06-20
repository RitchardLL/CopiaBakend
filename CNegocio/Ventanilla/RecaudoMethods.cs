using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
    public class RecaudoMethods
    {
        private ManagerRecaudosModel ADRecaudosManager;

        public RecaudoMethods()
        {
            ADRecaudosManager = new ManagerRecaudosModel();
        }
        public bool Crear(RecaudosModel aRecaudos)
        {
            return ADRecaudosManager.Insert(aRecaudos);
        }

        public bool Editar(RecaudosModel aRecaudos)
        {
            return ADRecaudosManager.Update(aRecaudos);
        }

        public bool Eliminar(int aNro_Contrato)
        {
            return ADRecaudosManager.Delete(aNro_Contrato);
        }

        public RecaudosModel ObtenerUno(int aNro_Contrato)
        {
            return ADRecaudosManager.GetRecaudosModel(aNro_Contrato);
        }

        public List<RecaudosModel> ObtenerTodos()
        {
            return ADRecaudosManager.RecaudosModelSelectAll();
        }
    }
}
