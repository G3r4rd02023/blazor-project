using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Shared.Entidades
{
    public class DetalleVenta
    {
        public int Id { get; set; }

        public Venta Venta { get; set; } = null!;

        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string? Comentario { get; set; }

        public Producto Producto { get; set; } = null!;

        public int Cantidad { get; set; }


    }
}
