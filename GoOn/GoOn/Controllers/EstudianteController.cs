using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BL;
using Entity;
namespace GoOn.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Index()
        {
            return View();
        }

        // Agregar Estudiante 
        [HttpGet]
        public ActionResult Agregar()
        {
           
            return View();

        }

        [HttpPost]
        public ActionResult Agregar(EstudianteO objectExample)
        {
            // Llamada al metodo en BL
            return View();
        }
    }
}