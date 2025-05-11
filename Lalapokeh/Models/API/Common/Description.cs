namespace Lalapokeh.Models.API.Common
{
  /// <summary>
  /// Represents a localized description for an API resource.
  /// </summary>
  public class Description
  {
    /// <summary>
    /// The localized description for an API resource in a specific language.
    /// </summary>
    public required string DescriptionText { get; set; }

    /// <summary>
    /// The language this description is in.
    /// </summary>
    public required NamedApiResource Language { get; set; }
  }
}