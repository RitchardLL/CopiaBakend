using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class TurnosMethods
    {
        private ManagerTurnosModel ADTurnosManager;

        public TurnosMethods()
        {
            ADTurnosManager = new ManagerTurnosModel();
        }
        public bool Crear(TurnosModel aTurnos)
        {
            return ADTurnosManager.Insert(aTurnos);
        }

        public bool Editar(TurnosModel aTurnos)
        {
            return ADTurnosManager.Update(aTurnos);
        }

        public bool Eliminar(int aID_Turnos)
        {
            return ADTurnosManager.Delete(aID_Turnos);
        }

        public TurnosModel ObtenerUno(int aID_Turnos)
        {
            return ADTurnosManager.GetTurnosModel(aID_Turnos);
        }

        public List<TurnosModel> ObtenerTodos()
        {
            return ADTurnosManager.TurnosModelSelectAll();
        }
    }
}
