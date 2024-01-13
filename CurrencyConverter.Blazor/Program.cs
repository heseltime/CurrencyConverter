using CurrencyConverter.Blazor;
using CurrencyConverter.Blazor.Services.Generated;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// best practice:
builder.Services.AddHttpClient<IConverterService, ConverterService>(
    client => client.BaseAddress = new Uri("https://localhost:5001")
    );

await builder.Build().RunAsync();
