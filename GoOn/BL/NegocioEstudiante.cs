using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

using DAL; // Uso de using para la capa de acceso a datos.
namespace BL
{
    public class NegocioEstudiante
    {
        
       
        // Agregar Usuario
        public bool AgregarUsuarioNeg(int? rut, string dv, string username, string pass, string names, string lastNames, string correo, int celular, DateTime fechaRegistro,
                                  int idCarrera, int idTipoUser )
        {
            
            bool flag = false;
            try
            {
                using ( var bd = new GoOnEntities())
                {
                    bd.sp_Crear_Usuario(rut, dv, username, pass, names, lastNames, correo, celular, fechaRegistro, idCarrera, idTipoUser);
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                Console.WriteLine(ex.ToString());
            }
            return flag;
        }

        public List<Entity.EstudianteO> listadoEstudiantes()
        {
            List<Entity.EstudianteO> lista = null;

            using (var bd = new DAL.GoOnEntities())
            {
                lista = (from u in bd.Usuario
                         select new Entity.EstudianteO
                         {
                             rut = u.rut,
                             dv = u.dv,
                             username = u.username,
                             password = u.passwd,
                             nombres = u.nombres,
                             apellidos = u.apellidos,
                             correo = u.correo,
                             celular = u.celular,
                             fechaRegistro = u.fecha_registro,
                             idCarrera = u.id_carrera,
                             idTipoUser = u.id_tipouser
                         }).ToList();  
            }
            return lista;
        }
    }
}
