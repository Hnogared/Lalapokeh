using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Ability
{
  /// <summary>
  /// Represents a Pokémon ability, including its characteristics and associated Pokémon.
  /// </summary>
  public class Ability
  {
    /// <summary>
    /// The identifier for this resource.
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// The name for this resource.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Whether or not this ability originated in the main series of the video games.
    /// </summary>
    public required bool IsMainSeries { get; set; }

    /// <summary>
    /// The generation this ability originated in.
    /// </summary>
    public required NamedApiResource Generation { get; set; }

    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    public required List<ApiName> Names { get; set; }

    /// <summary>
    /// The effect of this ability listed in different languages.
    /// </summary>
    public required List<VerboseEffect> EffectEntries { get; set; }

    /// <summary>
    /// The list of previous effects this ability has had across version groups.
    /// </summary>
    public required List<AbilityEffectChange> EffectChanges { get; set; }

    /// <summary>
    /// The flavor text of this ability listed in different languages.
    /// </summary>
    public required List<AbilityFlavorText> FlavorTextEntries { get; set; }

    /// <summary>
    /// A list of Pokémon that could potentially have this ability.
    /// </summary>
    public required List<AbilityPokemon> Pokemon { get; set; }
  }
}