using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoOn.Services.BL;
using GoOn.Models.Entidades;
using System.IO;
namespace GoOn.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Index()
           
        {
            // instancio clase Negocio Estudiante 
            ListCollection collection = new ListCollection();
            var listado = collection.Get_Multiple_Views();
            return View(listado);
        }

        // Agregar Estudiante 
        [HttpGet]
        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(FormCollection form, Models.Usuario image)
        {
            
            // Llamada al metodo en BL
            ListCollection c = new ListCollection();
            try
            {
                if (ModelState.IsValid)
                {
                    var rut = Request.Form["rut"];
                    var dv = Request.Form["dv"];
                    var username = Request.Form["username"];
                    var pass = Request.Form["password"];
                    var nombres = Request.Form["nombres"];
                    var apellidos = Request.Form["apellidos"];
                    var correo = Request.Form["correo"];
                    var celular = Request.Form["celular"];
                    var fecha = Request.Form["fecha"];
                    string fileName = Path.GetFileNameWithoutExtension(image.imageFile.FileName);
                    string extension = Path.GetExtension(image.imageFile.FileName);
                    fileName = fileName + extension;
                    image.foto = "~/fotos/" + fileName;
                    fileName = Path.Combine(Server.MapPath("~/fotos/"), fileName);
                    image.imageFile.SaveAs(fileName);                    
                    var idCarrera = Request.Form["idCarrera"];
                    var carrera = idCarrera;

                    NegocioEstudiante BLEstudiante = new NegocioEstudiante();

                    var resultado = BLEstudiante.AgregarUsuarioNeg(Convert.ToInt32(rut), dv, username, pass, nombres, apellidos, correo,
                                                   Convert.ToInt32(celular), image.foto,Convert.ToDateTime(fecha),
                                                   Convert.ToInt32(idCarrera), 1);
                    
                    if (resultado) ViewBag.mensaje = TempData["message"] = "Usuario registrado exitosamente";
                    return View();
                }

            }
            catch (Exception ex )
            {
                ViewBag.mensaje = TempData["message"] = "Ocurrio un error al cargar los datos";
                Console.WriteLine(ex.ToString());
                return View();
            }

            return View();
        }

        // Perfil 
        [HttpGet]
        public ActionResult Perfil()
        {
            Models.GoOnEntities bd = new Models.GoOnEntities();
            return View(bd.Usuario.ToList());
        }

        [HttpGet]
        public ActionResult Actualizar(string rut)
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                ViewBag.error = ex.ToString(); // Solo en modo Debug, no en produccion.

            }
            return View();
        }

    }
}