using Modelos.Modelos;
using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Backend
{
    interface ITipoDocumentoService
    {
        [OperationContract]
        bool TipoDocumento_Crear(TipoDocumentoModel aTipoDocumento);

        [OperationContract]
        bool TipoDocumento_Editar(TipoDocumentoModel aTipoDocumento);

        [OperationContract]
        bool TipoDocumento_Eliminar(int aID_TipoDocumento);

        [OperationContract]
        TipoDocumentoModel TipoDocumento_ObtenerUno(int aID_TipoDocumento);

        [OperationContract]
        List<TipoDocumentoModel> TipoDocumento_ObtenerTodos();
    }
}
