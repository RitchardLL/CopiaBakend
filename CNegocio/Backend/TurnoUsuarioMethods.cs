using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class TurnoUsuarioMethods
    {
        private ManagerTurnoUsuarioModel ADTurnoUsuarioManager;

        public TurnoUsuarioMethods()
        {
            ADTurnoUsuarioManager = new ManagerTurnoUsuarioModel();
        }
        public bool Crear(TurnoUsuarioModel aTurnoUsuario)
        {
            return ADTurnoUsuarioManager.Insert(aTurnoUsuario);
        }

        public bool Editar(TurnoUsuarioModel aTurnoUsuario)
        {
            return ADTurnoUsuarioManager.Update(aTurnoUsuario);
        }

        public bool Eliminar(int aID_TurnoUsuario)
        {
            return ADTurnoUsuarioManager.Delete(aID_TurnoUsuario);
        }

        public TurnoUsuarioModel ObtenerUno(int aID_TurnoUsuario)
        {
            return ADTurnoUsuarioManager.GetTurnoUsuarioModel(aID_TurnoUsuario);
        }

        public List<TurnoUsuarioModel> ObtenerTodos()
        {
            return ADTurnoUsuarioManager.TurnoUsuarioModelSelectAll();
        }
    }
}
