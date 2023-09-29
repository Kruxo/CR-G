using Car_Rental.Business.Classes;
using Car_Rental.Data.Classes;
using G___Inlämning___Hao_Nguyen;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<BookingProcessor>();
builder.Services.AddSingleton<CollectionData>();

await builder.Build().RunAsync();
