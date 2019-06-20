using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace ServiciosBancarios.Ventanilla
{
    public interface IEmpresaService 
    {
        [OperationContract]
        bool Empresa_Crear(EmpresaModel aEmpresaModel);

        [OperationContract]
        bool Empresa_Editar(EmpresaModel aEmpresaModel);

        [OperationContract]
        bool Empresa_Eliminar(int aID_EmpresaModel);

        [OperationContract]
        EmpresaModel Empresa_ObtenerUno(int aID_EmpresaModel);

        [OperationContract]
        List<EmpresaModel> Empresa_ObtenerTodos();
    }
}