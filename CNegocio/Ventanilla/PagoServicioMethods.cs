using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
    public class PagoServicioMethods
    {
        private ManagerPagoServiciosModel ADPagoServicios;

        public PagoServicioMethods()
        {
            ADPagoServicios = new ManagerPagoServiciosModel();
        }
        public bool Crear(PagoServiciosModel aPagoServicios)
        {
            return ADPagoServicios.Insert(aPagoServicios);
        }

        public bool Editar(PagoServiciosModel aPagoServicios)
        {
            return ADPagoServicios.Update(aPagoServicios);
        }

        public bool Eliminar(int aNro_Contrato, int aID_Movimiento)
        {
            return ADPagoServicios.Delete(aNro_Contrato, aID_Movimiento);
        }

        public PagoServiciosModel ObtenerUno(int aNro_Contrato, int aID_Movimiento)
        {
            return ADPagoServicios.GetPagoServiciosModel( aNro_Contrato, aID_Movimiento);
        }

        public List<PagoServiciosModel> ObtenerTodos()
        {
            return ADPagoServicios.PagoServiciosModelSelectAll();
        }
    }
}
