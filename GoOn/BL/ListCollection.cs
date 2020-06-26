using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
    public class ListCollection
    {
        public List<Entity.EstudianteO> listadoEstudiantes { get; set; }
        public List<Entity.Carrera> listadoCarreras { get; set; }
        public List<DAL.tipo_usuario> listadoTipoUsuario { get; set; }

        public ListCollection Get_Multiple_Views()
        {
            List<Entity.EstudianteO> lista = new List<Entity.EstudianteO>();
            var multiple = new ListCollection();
            using (var bd = new DAL.GoOnEntities())
            {
                lista = (from u in bd.Usuario

                         join c in bd.carrera
                         on u.id_carrera equals c.id_carrera
                         join t in bd.tipo_usuario
                         on u.id_tipouser equals t.id_tipouser
                         where u.id_tipouser == 1                    
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
                             idTipoUser = u.id_tipouser,
                             nombrecarrera = c.carrera1
                         }).ToList();

                multiple.listadoEstudiantes = lista;


                List<Entity.Carrera> listaC = new List<Entity.Carrera>();
                    listaC = (from c in bd.carrera
                              select new Entity.Carrera
                              {
                                  idCarrera = c.id_carrera,
                                  carrera = c.carrera1
                              }).ToList();
                    multiple.listadoCarreras = listaC;
                
            }
            return multiple;
        }


    }

    


    
}
