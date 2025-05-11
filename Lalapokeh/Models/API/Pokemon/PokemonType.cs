using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Pokemon
{
  /// <summary>
  /// Represents a Pokémon's type.
  /// </summary>
  public class PokemonType
  {
    /// <summary>
    /// The order the Pokémon's types are listed in.
    /// </summary>
    public required int Slot { get; set; }

    /// <summary>
    /// The type the referenced Pokémon has.
    /// </summary>
    public required NamedApiResource Type { get; set; }
  }
}