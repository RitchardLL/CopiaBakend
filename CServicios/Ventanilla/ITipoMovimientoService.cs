using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Ventanilla
{
    public interface ITipoMovimientoService
    {
        [OperationContract]
        bool TipoMovimiento_Crear(MovimientosVentanillaModel aMovimientoVentanilla);

        [OperationContract]
        bool TipoMovimiento_Editar(MovimientosVentanillaModel aMovimientoVentanilla);

        [OperationContract]
        bool TipoMovimiento_Eliminar(int aID_Movimiento);

        [OperationContract]
        MovimientosVentanillaModel TipoMovimiento_ObtenerUno(int aID_Movimiento);

        [OperationContract]
        List<MovimientosVentanillaModel> TipoMovimiento_ObtenerTodos();
    }
}
