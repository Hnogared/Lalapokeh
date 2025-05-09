using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Ability
{
  /// <summary>
  /// Represents a Pokémon's ability and its characteristics, including whether it's hidden and its ability slot.
  /// </summary>
  public class AbilityPokemon
  {
    /// <summary>
    /// Whether or not this is a hidden ability for the referenced Pokémon.
    /// </summary>
    public required bool IsHidden { get; set; }

    /// <summary>
    /// Pokémon have 3 ability 'slots' which hold references to possible abilities they could have.
    /// This is the slot of this ability for the referenced Pokémon.
    /// </summary>
    public required int Slot { get; set; }

    /// <summary>
    /// The Pokémon this ability could belong to.
    /// </summary>
    public required NamedApiResource Pokemon { get; set; }
  }
}
