namespace Lalapokeh.Models.API.Common
{
  /// <summary>
  /// Represents localized flavor text for a specific version group in a specific language.
  /// </summary>
  public class VersionGroupFlavorText
  {
    /// <summary>
    /// The localized name for an API resource in a specific language.
    /// </summary>
    public required string Text { get; set; }

    /// <summary>
    /// The language this name is in.
    /// </summary>
    public required NamedApiResource Language { get; set; }

    /// <summary>
    /// The version group which uses this flavor text.
    /// </summary>
    public required NamedApiResource VersionGroup { get; set; }
  }
}
