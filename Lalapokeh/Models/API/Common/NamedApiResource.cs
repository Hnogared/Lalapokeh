namespace Lalapokeh.Models.API.Common
{
  /// <summary>
  /// Represents a named resource with a URL in the API.
  /// </summary>
  public class NamedApiResource
  {
    /// <summary>
    /// The name of the resource.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// The URL of the resource.
    /// </summary>
    public required string Url { get; set; }
  }
}