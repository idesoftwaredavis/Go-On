using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoOn.Services.BL;
namespace GoOn.Controllers
{
    public class IniciarSesionController : Controller
    {
        // GET: IniciarSesion
        [HttpGet]
        public ActionResult IniciarSesion()
        {
            return View();
        }
        [HttpPost]
        public ActionResult IniciarSesion(FormCollection form)
        {
                var username = Request.Form["username"];
                var password = Request.Form["password"];

                NegocioEstudiante bl = new NegocioEstudiante();
                var resultado =  bl.IniciaSesion(username, password);
                if (resultado) return RedirectToAction("Index", "Estudiante");
                else return View();
        }    
    }
}