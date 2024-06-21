using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ecommerce.Shared.Entidades
{
    public class Producto
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombre { get; set; } = null!;

        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int Stock { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Descripcion { get; set; } = null!;

        [Display(Name = "Foto")]
        public string? URLFoto { get; set; }

        public Categoria Categoria { get; set; } = null!;

        [Range(1, int.MaxValue, ErrorMessage = "Debes de seleccionar una categoria.")]
        public int CategoriaId { get; set; }
       
    }
}
