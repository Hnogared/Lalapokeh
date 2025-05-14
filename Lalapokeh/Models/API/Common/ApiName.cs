namespace Lalapokeh.Models.API.Common
{
  /// <summary>
  /// Represents the localized name of an API resource in a specific language.
  /// </summary>
  public class ApiName
  {
    /// <summary>
    /// The localized name for an API resource in a specific language.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// The language this name is in.
    /// </summary>
    public required NamedApiResource Language { get; set; }
  }
}