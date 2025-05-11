using Lalapokeh.Models.API.Pokemon;
using Lalapokeh.Services.Abstractions;

namespace Lalapokeh.Services
{
  /// <summary>
  /// Service for retrieving Pokémon data from the PokeAPI.
  /// </summary>
  public class PokemonService(HttpClient httpClient) : BasePokeApiService<Pokemon>(httpClient, "pokemon") { }
}