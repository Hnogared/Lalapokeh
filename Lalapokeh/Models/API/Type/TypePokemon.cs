using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Type
{
  /// <summary>
  /// Represents a Pokémon's type information.
  /// </summary>
  public class TypePokemon
  {
    /// <summary>
    /// The order the Pokémon's types are listed in.
    /// </summary>
    public required int Slot { get; set; }

    /// <summary>
    /// The Pokémon that has the referenced type.
    /// </summary>
    public required NamedApiResource Pokemon { get; set; }
  }
}