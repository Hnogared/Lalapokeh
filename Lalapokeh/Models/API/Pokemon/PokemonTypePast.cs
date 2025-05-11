using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Pokemon
{
  /// <summary>
  /// Represents a Pokémon's types from previous generations.
  /// </summary>
  public class PokemonTypePast
  {
    /// <summary>
    /// The last generation in which the Pokémon had the listed types.
    /// </summary>
    public required NamedApiResource Generation { get; set; }

    /// <summary>
    /// The types the Pokémon had in previous generations.
    /// </summary>
    public required List<PokemonType> Types { get; set; }
  }
}