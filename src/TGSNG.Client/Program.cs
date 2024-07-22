using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TGSNG.Client.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<ClientApp>("#app");

await builder.Build().RunAsync();
