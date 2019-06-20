using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
    public  class TipoMonedaMethods
    {

        //Tipo de cambio? o tipoMoenda ?  
        private ManagerTipoCambioManager ADTipoMonedaManager;

        public TipoMonedaMethods()
        {
            ADTipoMonedaManager = new ManagerTipoCambioManager();
        }
        //public bool Crear(TipoMonedaModel aTipoMoneda)
        //{
        //    return ADTipoMonedaManager.Insert(aTipoMoneda);
        //}

        //public bool Editar(TipoMonedaModel aTipoMoneda)
        //{
        //    return ADTipoMonedaManager.Update(aTipoMoneda);
        //}

        //public bool Eliminar(int aID_Cheque, int aID_Movimiento)
        //{
        //    return ADTipoMonedaManager.Delete(aID_Cheque, aID_Movimiento);
        //}

        //public TipoMonedaModel ObtenerUno(int aID_Cheque, int aID_Movimiento)
        //{
        //    return ADTipoMonedaManager.GetCobroChequesModel(aID_Cheque, aID_Movimiento);
        //}

        //public List<TipoMonedaModel> ObtenerTodos()
        //{
        //    return ADTipoMonedaManager.CobroChequesModelSelectAll();
        //}
    }
}
