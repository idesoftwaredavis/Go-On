using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


using DAL; // Uso de using para la capa de acceso a datos.
namespace BL
{
    public class NegocioEstudiante : ListCollection
    {   
        // Agregar Usuario
        public bool AgregarUsuarioNeg(int? rut, string dv, string username, string pass, string names, string lastNames, string correo, string foto, int celular, DateTime fechaRegistro,
                                  int idCarrera, int idTipoUser )
        {
            
            bool flag = false;
            try
            {
                using ( var bd = new GoOnEntities())
                {
                    
                    bd.sp_Crear_Usuario(rut, dv, username, pass, names, lastNames, correo,foto, celular, fechaRegistro, idCarrera, idTipoUser);

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

        // Íniciar Sesion
        public bool IniciaSesion(string nombreUsuario, string contraseña)
        {
            var resultado = false;
            try
            {             
                using (var bd = new DAL.GoOnEntities())
                {

                     
resultado = bd.Usuario.Any(x => x.username == nombreUsuario && x.passwd == contraseña);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                
            }
            return resultado;
        }



    
    }
}
