using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class BancoMethods
    {
        private ManagerBancoModel ADBancoManager;

        public BancoMethods()
        {
            ADBancoManager = new ManagerBancoModel();
        }
        public bool Crear(BancoModel aBanco)
        {
            return ADBancoManager.Insert(aBanco);
        }

        public bool Editar(BancoModel aBanco)
        {
            return ADBancoManager.Update(aBanco);
        }

        public bool Eliminar(int aID_Banco)
        {
            return ADBancoManager.Delete(aID_Banco);
        }

        public BancoModel ObtenerUno(int aID_Banco)
        {
            return ADBancoManager.GetBancoModel(aID_Banco);
        }

        public List<BancoModel> ObtenerTodos()
        {
            return ADBancoManager.BancoModelSelectAll();
        }
    }
}

