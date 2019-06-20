
using CDatos.Manager;
using Modelos.Modelos;
using System.Collections.Generic;

namespace CNegocio.Ventanilla
{
    public class VentanillaMethods
    {
        private ManagerVentanillaModel ADVentanillaManager;

        public VentanillaMethods()
        {
            ADVentanillaManager = new ManagerVentanillaModel();
        }
        public bool Crear(VentanillaModel aVentanilla)
        {
            return ADVentanillaManager.Insert(aVentanilla);
        }

        public bool Editar(VentanillaModel aVentanilla)
        {
            return ADVentanillaManager.Update(aVentanilla);
        }

        public bool Eliminar(int aID_VentanillaModel)
        {
            return ADVentanillaManager.Delete(aID_VentanillaModel);
        }

        public VentanillaModel ObtenerUno(int aID_VentanillaModel)
        {
            return ADVentanillaManager.GetVentanillaModel(aID_VentanillaModel);
        }

        public List<VentanillaModel> ObtenerTodos()
        {
            return ADVentanillaManager.VentanillaModelSelectAll();
        }
    }

}