using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Pokemon
{
  /// <summary>
  /// Represents a Pokémon's past abilities from previous generations.
  /// </summary>
  public class PokemonAbilityPast
  {
    /// <summary>
    /// The last generation in which the Pokémon had the listed abilities.
    /// </summary>
    public required NamedApiResource Generation { get; set; }

    /// <summary>
    /// The abilities the Pokémon had up to and including the listed generation.
    /// </summary>
    public required List<PokemonAbility> Abilities { get; set; }
  }
}