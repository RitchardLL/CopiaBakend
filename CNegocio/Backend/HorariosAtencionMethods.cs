using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class HorariosAtencionMethods
    {
        private ManagerHorarios_AtencionModel ADHorariosAtencionManager;

        public HorariosAtencionMethods()
        {
            ADHorariosAtencionManager = new ManagerHorarios_AtencionModel();
        }
        public bool Crear(Horarios_AtencionModel aHorariosAtencion)
        {
            return ADHorariosAtencionManager.Insert(aHorariosAtencion);
        }

        public bool Editar(Horarios_AtencionModel aHorariosAtencion)
        {
            return ADHorariosAtencionManager.Update(aHorariosAtencion);
        }

        public bool Eliminar(int aID_HorariosAtencion)
        {
            return ADHorariosAtencionManager.Delete(aID_HorariosAtencion);
        }

        public Horarios_AtencionModel ObtenerUno(int aID_HorariosAtencion)
        {
            return ADHorariosAtencionManager.GetHorarios_AtencionModel(aID_HorariosAtencion);
        }

        public List<Horarios_AtencionModel> ObtenerTodos()
        {
            return ADHorariosAtencionManager.Horarios_AtencionModelSelectAll();
        }
    }
}
