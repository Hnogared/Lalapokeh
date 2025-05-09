namespace Lalapokeh.Models.API.Common
{
  /// <summary>
  /// Represents a generic API resource that includes only a URL.
  /// </summary>
  public class APIResource
  {
    /// <summary>
    /// The URL of the referenced resource.
    /// </summary>
    public required string Url { get; set; }
  }
}
