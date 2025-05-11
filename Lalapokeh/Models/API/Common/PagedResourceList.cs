namespace Lalapokeh.Models.API.Common
{
  /// <summary>
  /// Represents a paginated response list from the API.
  /// </summary>
  public class PagedResourceList<ResourceType>
  {
    /// <summary>
    /// The total number of resources available from this API.
    /// </summary>
    public required int Count { get; set; }

    /// <summary>
    /// The URL for the next page in the list.
    /// </summary>
    public string? Next { get; set; }

    /// <summary>
    /// The URL for the previous page in the list.
    /// </summary>
    public string? Previous { get; set; }

    /// <summary>
    /// A list of named API resources.
    /// </summary>
    public required List<ResourceType> Results { get; set; }
  }
}