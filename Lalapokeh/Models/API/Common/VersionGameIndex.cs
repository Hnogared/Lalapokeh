namespace Lalapokeh.Models.API.Common
{
  /// <summary>
  /// Represents a version-specific game index for an API resource.
  /// </summary>
  public class VersionGameIndex
  {
    /// <summary>
    /// The internal ID of an API resource within game data.
    /// </summary>
    public required int GameIndex { get; set; }

    /// <summary>
    /// The version relevant to this game index.
    /// </summary>
    public required NamedApiResource Version { get; set; }
  }
}