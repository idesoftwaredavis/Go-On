using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using System.Web;
namespace Entity
{
    public class EstudianteO 
    {
        [Required]
        [Display (Name ="Rut Usuario")]
        public int? rut { get; set; }
        [Required]
        [StringLength (1, ErrorMessage = "El dv consta de 1 solo digito ( Incluye - K [caracteres]")]
        public string dv { get; set; }
        [Required]
        [Display(Name = "Nombre de Usuario")]
        [StringLength(25, ErrorMessage ="El campo contiene un maximo de longitud de caracteres permitidos, modifique por favor")]
        public string username { get; set; }
        [Required]
        [Display(Name = "Contraseña")]
        [StringLength(10,  ErrorMessage ="La contraseña debe tener como maximo 10 caracteres")]
        public string password { get; set; }
        [StringLength(50, ErrorMessage ="Campo supera el limite maximo de longitud")]
        public string nombres { get; set; }
        [StringLength(50, ErrorMessage ="Campo supera el limite maximo de longitud")]
        public string apellidos { get; set; }
        [Required]
        [StringLength(50, ErrorMessage ="Camppo supera el limite maximo de longitud permitido")]
        public string correo { get; set; }
        [Required]
        [StringLength(9, ErrorMessage ="Digito maximo de 9, vuelva a intentarlo")]
        public int celular { get; set; }
        [Required]
        public DateTime fechaRegistro { get; set; }
        [Required]
        public int? idCarrera { get; set; }
        [Required]
        public int? idTipoUser { get; set; }

        public string foto { get; set; }
        public string nombrecarrera { get; set; }
        
    }
}
