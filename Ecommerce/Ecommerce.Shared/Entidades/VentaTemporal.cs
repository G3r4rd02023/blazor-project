using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Shared.Entidades
{
    public class VentaTemporal
    {
        public int Id { get; set; }

        public Usuario Usuario { get; set; } = null!;

        public Producto Producto { get; set; } = null!;

        public int Cantidad { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string? Comentario { get; set; }


    }
}
