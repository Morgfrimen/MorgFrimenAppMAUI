using BlazorWebAssembly;
using BlazorWebAssembly.ViewModels;
using BlazorWebAssembly.ViewModels.Adstract;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

#region ViewModels global
builder.Services.AddScoped<ICounterViewModels, CounterViewModels>();
#endregion

await builder.Build().RunAsync();
