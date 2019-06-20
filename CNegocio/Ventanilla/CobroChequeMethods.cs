using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
    public class CobroChequeMethods
    {
        private ManagerCobroChequesModel ADCobroChqueManager;

        public CobroChequeMethods()
        {
            ADCobroChqueManager = new ManagerCobroChequesModel();
        }
        public bool Crear(CobroChequesModel aCobroCheque)
        {
            return ADCobroChqueManager.Insert(aCobroCheque);
        }

        public bool Editar(CobroChequesModel aCobroCheque)
        {
            return ADCobroChqueManager.Update(aCobroCheque);
        }

        public bool Eliminar(int aID_Cheque, int aID_Movimiento)
        {
            return ADCobroChqueManager.Delete(aID_Cheque, aID_Movimiento);
        }

        public CobroChequesModel ObtenerUno(int aID_Cheque, int aID_Movimiento)
        {
            return ADCobroChqueManager.GetCobroChequesModel(aID_Cheque, aID_Movimiento);
        }

        public List<CobroChequesModel> ObtenerTodos()
        {
            return ADCobroChqueManager.CobroChequesModelSelectAll();
        }
    }
}
