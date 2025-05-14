using Lalapokeh;
using Lalapokeh.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using System.Text.Json;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

#region Root components
builder.RootComponents.Add<App>("#app");

builder.RootComponents.Add<HeadOutlet>("head::after");
#endregion

#region Services
builder.Services.AddScoped(sp =>
{
  var baseUrl = builder.Configuration["ApiUrl"];

  if (baseUrl is null)
  {
    throw new InvalidOperationException("API URL must be set in the app settings.");
  }

  // Ensure HTTPS is enforced
  if (!baseUrl.StartsWith("https", StringComparison.OrdinalIgnoreCase))
  {
    throw new InvalidOperationException("API must be accessed over HTTPS.");
  }

  return new HttpClient
  {
    BaseAddress = new Uri(baseUrl),
    Timeout = TimeSpan.FromSeconds(
      int.TryParse(builder.Configuration["RequestTimeout"], out var timeout) ? timeout : 10
    )
  };
});

builder.Services.AddMudServices();

builder.Services.AddSingleton<AppThemeService>();

builder.Services.AddLogging(config =>
{
  _ = config.AddDebug();
});

builder.Services.AddSingleton(new JsonSerializerOptions
{
  PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
  PropertyNameCaseInsensitive = true,
});

builder.Services.AddScoped<PokemonService>(sp =>
{
  var httpClient = sp.GetRequiredService<HttpClient>();
  var logger = sp.GetRequiredService<ILogger<PokemonService>>();
  var jsonOptions = sp.GetRequiredService<JsonSerializerOptions>();
  return new PokemonService(httpClient, logger, jsonOptions);
});
#endregion

await builder.Build().RunAsync();