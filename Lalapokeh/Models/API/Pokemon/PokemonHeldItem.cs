using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Pokemon
{
  /// <summary>
  /// Represents an item a Pokémon holds.
  /// </summary>
  public class PokemonHeldItem
  {
    /// <summary>
    /// The item the referenced Pokémon holds.
    /// </summary>
    public required NamedApiResource Item { get; set; }

    /// <summary>
    /// The details of different versions in which the item is held.
    /// </summary>
    public required List<PokemonHeldItemVersion> VersionDetails { get; set; }
  }
}