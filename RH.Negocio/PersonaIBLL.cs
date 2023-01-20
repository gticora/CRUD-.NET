using RH.Datos;
using RH.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Negocio
{
    public class PersonaIBLL
    {
        public bool ActualizarPersona(int idPersona, Persona persona)
        {
            return new PersonaDAL().ActualizarPersona(idPersona, persona);
        }

        public bool EliminarPersona(int idPersona)
        {
            return new PersonaDAL().EliminarPersona(idPersona);
        }

        public bool InsertarPersona(Persona persona)
        {
            return new PersonaDAL().InsertarPersona(persona);
        }

        public List<Persona> ListarPersonas()
        {
            return new PersonaDAL().ListarPersonas();
        }

        public Persona ConsultarPersona(int idPersona)
        {
            return new PersonaDAL().ConsultarPersona(idPersona);
        }
    }
}
