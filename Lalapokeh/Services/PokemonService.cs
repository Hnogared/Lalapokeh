using Lalapokeh.Models.API.Pokemon;
using Lalapokeh.Services.Abstractions;
using System.Text.Json;

namespace Lalapokeh.Services
{
  /// <summary>
  /// Service for retrieving Pokémon data from the PokeAPI.
  /// </summary>
  public class PokemonService(
    HttpClient httpClient,
    ILogger<PokemonService> logger,
    JsonSerializerOptions jsonOptions
  ) : BasePokeApiService<Pokemon>(httpClient, "pokemon", logger, jsonOptions)
  { }
}