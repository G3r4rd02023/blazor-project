using Ecommerce.Shared.Entidades;

namespace Ecommerce.Frontend.Services
{
    public interface ICategoriaService
    {
        Task<List<Categoria>> Lista();
    }
}
