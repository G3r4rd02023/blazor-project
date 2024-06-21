using Ecommerce.Shared;
using Ecommerce.Shared.Entidades;
using System.Net.Http.Json;


namespace Ecommerce.Frontend.Services
{
    public class CategoriaService : ICategoriaService
    {

        private readonly HttpClient _http;

        public CategoriaService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Categoria>> Lista()
        {
            var result = await _http.GetFromJsonAsync<ResponseApi<List<Categoria>>>("api/Categorias");

            if (result!.EsCorrecto)
            {
                return result.Valor!;
            }
            else
            {
                throw new Exception(result.Mensaje);
            }
        }

        public async Task<Categoria> Buscar(int id)
        {
            var result = await _http.GetFromJsonAsync<ResponseApi<Categoria>>($"api/Categorias/{id}");

            if (result!.EsCorrecto)
                return result.Valor!;
            else
                throw new Exception(result.Mensaje);
        }

        public async Task<int> Guardar(Categoria categoria)
        {
            var result = await _http.PostAsJsonAsync("api/Categorias", categoria);
            var response = await result.Content.ReadFromJsonAsync<ResponseApi<int>>();

            if (response!.EsCorrecto)
                return response.Valor!;
            else
                throw new Exception(response.Mensaje);
        }

        public async Task<int> Editar(Categoria categoria)
        {
            var result = await _http.PutAsJsonAsync($"api/Categorias/{categoria.Id}", categoria);
            var response = await result.Content.ReadFromJsonAsync<ResponseApi<int>>();

            if (response!.EsCorrecto)
                return response.Valor!;
            else
                throw new Exception(response.Mensaje);
        }

        public async Task<bool> Eliminar(int id)
        {
            var result = await _http.DeleteAsync($"api/Categorias/{id}");
            var response = await result.Content.ReadFromJsonAsync<ResponseApi<int>>();

            if (response!.EsCorrecto)
                return response.EsCorrecto!;
            else
                throw new Exception(response.Mensaje);
        }

    }
}
