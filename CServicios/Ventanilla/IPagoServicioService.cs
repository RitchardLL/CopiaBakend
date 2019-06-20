using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Ventanilla
{
    public interface IPagoServicioService
    {
        [OperationContract]
        bool PagoServicio_Crear(PagoServiciosModel aPagoServicios);

        [OperationContract]
        bool PagoServicio_Editar(PagoServiciosModel aPagoServicios);

        [OperationContract]
        bool PagoServicio_Eliminar(int aNro_Contrato, int aID_Movimiento);

        [OperationContract]
        PagoServiciosModel PagoServicio_ObtenerUno(int aNro_Contrato, int aID_Movimiento);

        [OperationContract]
        List<PagoServiciosModel> PagoServicio_ObtenerTodos();
    }
}
