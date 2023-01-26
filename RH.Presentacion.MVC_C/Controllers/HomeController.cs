using Newtonsoft.Json;
using RH.Presentacion.MVC_C.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RH.Presentacion.MVC_C.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Listar()
        {
            List<PersonaModel> personas = new List<PersonaModel>();


            var url = $"http://localhost:60452/api/ListarPersona";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        //if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            personas = JsonConvert.DeserializeObject<List<PersonaModel>>(responseBody);

                        }
                    }
                }
            }
            catch (WebException ex)
            {
                TempData["valor"] = ex.Message;
            }

            ViewBag.Personas = personas;
           // TempData["valor"] = "Se elimino correctamente";
            ViewBag.Message = TempData["Valor"];
           

            return View();


        }


        public ActionResult FormCreateUpdate(string id = null)
        {
           
            if (!string.IsNullOrEmpty(id))
            {
                PersonaModel persona = new PersonaModel();
                var url = $"http://localhost:60452/api/ConsultarPersona?IdPersona={id}";
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Accept = "application/json";
                try
                {
                    using (WebResponse response = request.GetResponse())
                    {
                        using (Stream strReader = response.GetResponseStream())
                        {
                            //if (strReader == null) return;
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                // Do something with responseBody
                                persona = JsonConvert.DeserializeObject<PersonaModel>(responseBody);

                            }
                        }
                    }
                }
                catch (WebException ex)
                {
                    // Handle error
                }
                ViewBag.Persona = persona;
                ViewBag.Title = "Editar persona";
                return View(persona);

            }
            else
            {
                ViewBag.Title = "Crear persona";
                return View();
            }


        }



        public ActionResult Delete(int id)
        {
            var url = $"http://localhost:60452/api/EliminarPersona?IdPersona={id}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "DELETE";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        //if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            TempData["valor"] = "Se elimino correctamente";

                        }
                    }
                }
            }
            catch (WebException ex)
            {
               
                TempData["valor"] = ex.Message;
            }
           
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult CreateUpdate(PersonaModel persona)
        {
            if (persona.IdPersona == 0)
            {
                Create(persona);
                return RedirectToAction("Listar");
            }
            else
            {
                Update(persona.IdPersona,persona);
                return RedirectToAction("Listar");
            }
       
        }

        public void Update(int id, PersonaModel data)
        {

            var url = $"http://localhost:60452/api/ActualizarPersona?IdPersona={id}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            string json = JsonConvert.SerializeObject(data);
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        //if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            TempData["valor"] = "Se actualizo correctamente";
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                TempData["valor"] = ex.Message;
            }

        }



        public void Create(PersonaModel persona)
        {
            //data strserialize = JsonConvert.SerializeObject(persona);

            var url = $"http://localhost:60452/api/CreatePersona";
            var request = (HttpWebRequest)WebRequest.Create(url);
            string json = JsonConvert.SerializeObject(persona);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        //if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            TempData["valor"] = "Se creo correctamente";
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                TempData["valor"] = ex.Message;
            }

        }




        [HttpPost]
        public bool Eliminar(int IdPersona)
        {
            var url = $"http://localhost:60452/api/EliminarPersona?IdPersona={IdPersona}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "DELETE";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        //if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            return true;

                        }
                    }
                }
            }
            catch (WebException ex)
            {

                return false;
            }

            
        }

    }
}