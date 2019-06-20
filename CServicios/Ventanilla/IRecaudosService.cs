using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Ventanilla
{
    public interface IRecaudosService
    {
        [OperationContract]
        bool Recaudos_Crear(RecaudosModel aRecaudos);

        [OperationContract]
        bool Recaudos_Editar(RecaudosModel aRecaudos);

        [OperationContract]
        bool Recaudos_Eliminar(int aNro_Contrato);

        [OperationContract]
        RecaudosModel Recaudos_ObtenerUno(int aNro_Contrato);

        [OperationContract]
        List<RecaudosModel> Recaudos_ObtenerTodos();
    }
}
