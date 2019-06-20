using Modelos.Modelos;
using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Backend
{
    interface ITurnosService
    {
        [OperationContract]
        bool Turnos_Crear(TurnosModel aTurnos);

        [OperationContract]
        bool Turnos_Editar(TurnosModel aTurnos);

        [OperationContract]
        bool Turnos_Eliminar(int aID_Turnos);

        [OperationContract]
        TurnosModel Turnos_ObtenerUno(int aID_Turnos);

        [OperationContract]
        List<TurnosModel> Turnos_ObtenerTodos();
    }
}
