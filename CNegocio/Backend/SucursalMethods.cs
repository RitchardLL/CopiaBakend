using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class SucursalMethods
    {
        private ManagerSucursalModel ADSucursalManager;

        public SucursalMethods()
        {
            ADSucursalManager = new ManagerSucursalModel();
        }
        public bool Crear(SucursalModel aSucursal)
        {
            return ADSucursalManager.Insert(aSucursal);
        }

        public bool Editar(SucursalModel aSucursal)
        {
            return ADSucursalManager.Update(aSucursal);
        }

        public bool Eliminar(int aID_Sucursal)
        {
            return ADSucursalManager.Delete(aID_Sucursal);
        }

        public SucursalModel ObtenerUno(int aID_Sucursal)
        {
            return ADSucursalManager.GetSucursalModel(aID_Sucursal);
        }

        public List<SucursalModel> ObtenerTodos()
        {
            return ADSucursalManager.SucursalModelSelectAll();
        }
    }
}
