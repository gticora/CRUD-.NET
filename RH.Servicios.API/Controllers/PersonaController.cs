using RH.Entidades;
using RH.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RH.Servicios.API.Controllers
{
    public class PersonaController : ApiController
    {
        [HttpPost]
        [Route("api/CreatePersona")]
        public IHttpActionResult CreatePersona(Persona persona)
        {
            return Ok(new PersonaIBLL().InsertarPersona(persona));
        }


        [HttpGet]
        [Route("api/ListarPersona")]
        public IHttpActionResult ListarPersonas()
        {
            return Ok(new PersonaIBLL().ListarPersonas());
        }

        [HttpGet]
        [Route("api/ConsultarPersona")]
        public IHttpActionResult ConsultarPersona(int IdPersona)
        {
            return Ok(new PersonaIBLL().ConsultarPersona(IdPersona));
        }

        [HttpPut]
        [Route("api/ActualizarPersona")]
        public IHttpActionResult ActualizarPersona(int IdPersona, Persona persona)
        {
            return Ok(new PersonaIBLL().ActualizarPersona(IdPersona, persona));
        }


        [HttpDelete]
        [Route("api/EliminarPersona")]
        public IHttpActionResult EliminarPersona(int IdPersona)
        {
            return Ok(new PersonaIBLL().EliminarPersona(IdPersona));
        }

     

    }
}
