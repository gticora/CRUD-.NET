using Dapper;
using RH.Datos.Interfaces;
using RH.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Datos
{
    public class PersonaDAL : IPersonaDAL
    {
        public bool InsertarPersona(Persona persona)
        {
            SQLiteConnection con = new SQLiteConnection(RH.Datos.DbConect.Dbconect.GetCadena());

            Persona pe = new Persona();
            pe.IdPersona = -1;
            pe.Nombre = persona.Nombre;
            pe.Apellido = persona.Apellido;
            pe.Telefono = persona.Telefono;
            con.Insert<Persona>(pe);
           
            return true;
        }

        public bool EliminarPersona(int idPersona)
        {
            SQLiteConnection con = new SQLiteConnection(RH.Datos.DbConect.Dbconect.GetCadena());
            con.Delete<Persona>(idPersona);
            return true;
        }

        public List<Persona> ListarPersonas()
        {
            SQLiteConnection con = new SQLiteConnection(RH.Datos.DbConect.Dbconect.GetCadena());
             return (List<Persona>)con.GetList<Persona>();

            //throw new NotImplementedException();
        }

        public Persona ConsultarPersona(int idPersona)
        {
            SQLiteConnection con = new SQLiteConnection(RH.Datos.DbConect.Dbconect.GetCadena());
            Persona p = con.Get<Persona>(idPersona);
            return p;
        }

        public bool ActualizarPersona(int idPersona, Persona persona)
        {
            SQLiteConnection con = new SQLiteConnection(RH.Datos.DbConect.Dbconect.GetCadena());
            Persona p = con.Get<Persona>(idPersona);
            //con.Update<Persona>(p);
            p.Nombre = persona.Nombre;
            p.Apellido = persona.Apellido;
            p.Telefono = p.Telefono;

            con.Update<Persona>(p);

            return true;
        }
    }
}
