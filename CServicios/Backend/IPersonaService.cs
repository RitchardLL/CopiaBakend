using Modelos.Modelos;
using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Backend
{
    interface IPersonaService
    {
        [OperationContract]
        bool Persona_Crear(PersonaModel aPersona);

        [OperationContract]
        bool Persona_Editar(PersonaModel aPersona);

        [OperationContract]
        bool Persona_Eliminar(int aID_Persona);

        [OperationContract]
        PersonaModel Persona_ObtenerUno(int aID_Persona);

        [OperationContract]
        List<PersonaModel> Persona_ObtenerTodos();
    }
}