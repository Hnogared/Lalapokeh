namespace Lalapokeh.Models.API.Common
{
  /// <summary>
  /// Represents a language in which game content or resource names can be localized.
  /// </summary>
  public class Language
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
    /// Whether or not the games are published in this language.
    /// </summary>
    public required bool Official { get; set; }

    /// <summary>
    /// The two-letter code of the country where this language is spoken. Note that it is not unique.
    /// </summary>
    public required string Iso639 { get; set; }

    /// <summary>
    /// The two-letter code of the language. Note that it is not unique.
    /// </summary>
    public required string Iso3166 { get; set; }

    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    public required List<ApiName> Names { get; set; }
  }
}