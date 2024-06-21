using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shared.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombre { get; set; } = null!;

        [Display(Name = "Foto")]
        public string? URLFoto { get; set; }

        public string Rol { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Correo { get; set; } = null!;
       
        public string Clave { get; set; } = null!;

        public string Estado { get; set; } = null!;
    }
}
