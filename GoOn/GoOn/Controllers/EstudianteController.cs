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
            
            var rut = Request.Form["rut"];
            var dv = Request.Form["dv"];
            var username = Request.Form["username"];
            var pass = Request.Form["password"];
            var nombres = Request.Form["nombres"];
            var apellidos = Request.Form["apellidos"];
            var correo = Request.Form["correo"];
            var celular = Request.Form["celular"];
            var fecha = Request.Form["fecha"];

            var idCarrera = Request.Form["cars"];

            var carrera = idCarrera;
            BL.NegocioEstudiante BLEstudiante = new BL.NegocioEstudiante();
            
            
            //BLEstudiante.AgregarUsuarioNeg()
            return View();
        }
    }
}