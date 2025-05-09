namespace Lalapokeh.Models.API.Common
{
  /// <summary>
  /// Represents localized flavor text for an API resource in a specific language.
  /// </summary>
  public class FlavorText
  {
    /// <summary>
    /// The localized flavor text for an API resource in a specific language.
    /// Note that this text is left unprocessed as it is found in game files,
    /// containing special characters that one might want to replace with their visible decodable version.
    /// </summary>
    public required string FlavorTextValue { get; set; }

    /// <summary>
    /// The language this flavor text is in.
    /// </summary>
    public required NamedApiResource Language { get; set; }

    /// <summary>
    /// The game version this flavor text is extracted from.
    /// </summary>
    public required NamedApiResource Version { get; set; }
  }
}
