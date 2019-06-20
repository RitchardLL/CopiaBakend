using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
    public class TipoMovimientoMethods
    {
        private ManagerMovimientosVentanillaModel ADMovimientoVentanillaManager;

        public TipoMovimientoMethods()
        {
            ADMovimientoVentanillaManager = new ManagerMovimientosVentanillaModel();
        }
        public bool Crear(MovimientosVentanillaModel aMovimientoVentanilla)
        {
            return ADMovimientoVentanillaManager.Insert(aMovimientoVentanilla);
        }

        public bool Editar(MovimientosVentanillaModel aMovimientoVentanilla)
        {
            return ADMovimientoVentanillaManager.Update(aMovimientoVentanilla);
        }

        public bool Eliminar(int aID_Movimiento)
        {
            return ADMovimientoVentanillaManager.Delete(aID_Movimiento);
        }

        public MovimientosVentanillaModel ObtenerUno(int aID_Movimiento)
        {
            return ADMovimientoVentanillaManager.GetMovimientosVentanillaModel(aID_Movimiento);
        }

        public List<MovimientosVentanillaModel> ObtenerTodos()
        {
            return ADMovimientoVentanillaManager.MovimientosVentanillaModelSelectAll();
        }
    }
}
