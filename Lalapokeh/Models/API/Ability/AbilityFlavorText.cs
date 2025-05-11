using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Ability
{
  /// <summary>
  /// Represents the localized flavor text for an ability in a specific language and version group.
  /// </summary>
  public class AbilityFlavorText
  {
    /// <summary>
    /// The localized name for an API resource in a specific language.
    /// </summary>
    public required string FlavorText { get; set; }

    /// <summary>
    /// The language this text resource is in.
    /// </summary>
    public required NamedApiResource Language { get; set; }

    /// <summary>
    /// The version group that uses this flavor text.
    /// </summary>
    public required NamedApiResource VersionGroup { get; set; }
  }
}