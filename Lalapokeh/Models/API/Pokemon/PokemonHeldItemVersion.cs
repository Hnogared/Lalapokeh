using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Pokemon
{
  /// <summary>
  /// Represents a Pokémon's held item in different versions.
  /// </summary>
  public class PokemonHeldItemVersion
  {
    /// <summary>
    /// The version in which the item is held.
    /// </summary>
    public required NamedApiResource Version { get; set; }

    /// <summary>
    /// How often the item is held.
    /// </summary>
    public required int Rarity { get; set; }
  }
}