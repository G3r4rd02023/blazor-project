namespace Ecommerce.Shared
{
    public class ResponseApi<T>
    {
        public bool EsCorrecto { get; set; }
        public T? Valor { get; set; }
        public string? Mensaje { get; set; }
    }
}
