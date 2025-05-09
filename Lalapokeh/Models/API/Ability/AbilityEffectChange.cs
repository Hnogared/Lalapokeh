using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Ability
{
  /// <summary>
  /// Represents the change in the effect of an ability, including its previous effects and the version group it originated from.
  /// </summary>
  public class AbilityEffectChange
  {
    /// <summary>
    /// The previous effect of this ability listed in different languages.
    /// </summary>
    public required List<Effect> EffectEntries { get; set; }

    /// <summary>
    /// The version group in which the previous effect of this ability originated.
    /// </summary>
    public required NamedApiResource VersionGroup { get; set; }
  }
}
