using Modelos.Modelos;
using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Backend
{
    interface IHorariosAtencionService
    {
        [OperationContract]
        bool HorariosAtencion_Crear(Horarios_AtencionModel aHorariosAtencion);

        [OperationContract]
        bool HorariosAtencion_Editar(Horarios_AtencionModel aHorariosAtencion);

        [OperationContract]
        bool HorariosAtencion_Eliminar(int aID_HorariosAtencion);

        [OperationContract]
        Horarios_AtencionModel HorariosAtencion_ObtenerUno(int aID_HorariosAtencion);

        [OperationContract]
        List<Horarios_AtencionModel> HorariosAtencion_ObtenerTodos();
    }
}
