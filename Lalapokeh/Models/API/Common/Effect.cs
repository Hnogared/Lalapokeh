namespace Lalapokeh.Models.API.Common
{
  /// <summary>
  /// Represents a localized effect text for an API resource.
  /// </summary>
  public class Effect
  {
    /// <summary>
    /// The localized effect text for an API resource in a specific language.
    /// </summary>
    public required string EffectText { get; set; }

    /// <summary>
    /// The language this effect is in.
    /// </summary>
    public required NamedApiResource Language { get; set; }
  }
}