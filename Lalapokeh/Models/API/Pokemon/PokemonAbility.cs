using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Pokemon
{
  /// <summary>
  /// Represents a Pokémon's ability and its characteristics.
  /// </summary>
  public class PokemonAbility
  {
    /// <summary>
    /// Whether or not this is a hidden ability.
    /// </summary>
    public required bool IsHidden { get; set; }

    /// <summary>
    /// The slot this ability occupies in this Pokémon species.
    /// </summary>
    public required int Slot { get; set; }

    /// <summary>
    /// The ability the Pokémon may have.
    /// </summary>
    public required NamedApiResource Ability { get; set; }
  }
}