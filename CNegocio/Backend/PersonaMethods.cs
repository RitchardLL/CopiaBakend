using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class PersonaMethods
    {
        private ManagerPersonaModel ADPersonaManager;

        public PersonaMethods()
        {
            ADPersonaManager = new ManagerPersonaModel();
        }
        public bool Crear(PersonaModel aPersona)
        {
            return ADPersonaManager.Insert(aPersona);
        }

        public bool Editar(PersonaModel aPersona)
        {
            return ADPersonaManager.Update(aPersona);
        }

        public bool Eliminar(int aID_Persona)
        {
            return ADPersonaManager.Delete(aID_Persona);
        }

        public PersonaModel ObtenerUno(int aID_Persona)
        {
            return ADPersonaManager.GetPersonaModel(aID_Persona);
        }

        public List<PersonaModel> ObtenerTodos()
        {
            return ADPersonaManager.PersonaModelSelectAll();
        }
    }
}
