using Practiva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practiva.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Persona persona)

        {
            if (ModelState.IsValid) 
            {
                

                return View("Exito"); 
            }
            else
            {
                
                return View("Index",persona);
            }
                
        }
         
        public ActionResult Exito()
        {
            return View();
        }

        public ActionResult Requerido()
        {
            return View();
        }



    }
}