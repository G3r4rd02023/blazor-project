using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Ecommerce.Frontend
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
            builder.Services.AddBlazorBootstrap();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:7261") });

            await builder.Build().RunAsync();
        }
    }
}
