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
            // instancio clase Negocio Estudiante 
            NegocioEstudiante UsuarioBL = new NegocioEstudiante();
            var listado = UsuarioBL.listadoEstudiantes();
            return View(listado);
        }

        // Agregar Estudiante 
        [HttpGet]
        public ActionResult Agregar()
        {
           
            return View();

        }

        [HttpPost]
        public ActionResult Agregar(FormCollection form)
        {
            // Llamada al metodo en BL
           
            return View();
        }
    }
}