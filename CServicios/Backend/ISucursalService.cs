using Modelos.Modelos;
using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Backend
{
    interface ISucursalService
    {
        [OperationContract]
        bool Sucursal_Crear(SucursalModel aSucursal);

        [OperationContract]
        bool Sucursal_Editar(SucursalModel aSucursal);

        [OperationContract]
        bool Sucursal_Eliminar(int aID_Sucursal);

        [OperationContract]
        SucursalModel Sucursal_ObtenerUno(int aID_Sucursal);

        [OperationContract]
        List<SucursalModel> Sucursal_ObtenerTodos();
    }
}
