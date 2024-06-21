using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Shared.Entidades
{
    public class Venta
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public Usuario Usuario { get; set; } = null!;

        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string? Comentario { get; set; }

        public string EstadoPedido { get; set; } = null!;

        public ICollection<DetalleVenta> DetallesVenta { get; set; } = null!;

    }
}
