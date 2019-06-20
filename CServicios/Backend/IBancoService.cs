using Modelos.Modelos;
using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Backend
{
    public interface IBancoService
    {
        [OperationContract]
        bool Banco_Crear(BancoModel aBanco);

        [OperationContract]
        bool Banco_Editar(BancoModel aBanco);

        [OperationContract]
        bool Banco_Eliminar(int aID_Banco);

        [OperationContract]
        BancoModel Banco_ObtenerUno(int aID_Banco);

        [OperationContract]
        List<BancoModel> Banco_ObtenerTodos();
    }
}
