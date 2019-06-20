using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Ventanilla
{
    public interface ICobroChequeService
    {
        [OperationContract]
        bool CobroCheque_Crear(CobroChequesModel aCobroCheque);

        [OperationContract]
        bool CobroCheque_Editar(CobroChequesModel aCobroCheque);

        [OperationContract]
        bool CobroCheque_Eliminar(int aID_Cheque, int aID_Movimiento);

        [OperationContract]
        CobroChequesModel CobroCheque_ObtenerUno(int aID_Cheque, int aID_Movimiento);

        [OperationContract]
        List<CobroChequesModel> CobroCheque_ObtenerTodos();
    }
}
