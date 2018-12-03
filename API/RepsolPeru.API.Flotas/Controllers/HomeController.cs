using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RepsolPeru.API.Flotas.Controllers
{
    [RoutePrefix("api/Home")]
    public class HomeController : ApiController
    {

        /// <summary>
        /// Metodo Saludar
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        [HttpGet]
        public string Saludar(string nombre)
        {
            return string.Format("Hola {0}", nombre);
        }
    }
}
