namespace Lalapokeh.Models.API.Common
{
  /// <summary>
  /// Represents a localized effect text for an API resource in a specific language, with both a full and brief version.
  /// </summary>
  public class VerboseEffect
  {
    /// <summary>
    /// The localized effect text for an API resource in a specific language.
    /// </summary>
    public required string Effect { get; set; }

    /// <summary>
    /// The localized effect text in brief.
    /// </summary>
    public required string ShortEffect { get; set; }

    /// <summary>
    /// The language this effect is in.
    /// </summary>
    public required NamedApiResource Language { get; set; }
  }
}
