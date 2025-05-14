namespace Lalapokeh.Models.API.Common
{
  /// <summary>
  /// Represents a generation-specific game index for an API resource.
  /// </summary>
  public class GenerationGameIndex
  {
    /// <summary>
    /// The internal ID of an API resource within game data.
    /// </summary>
    public required int GameIndex { get; set; }

    /// <summary>
    /// The generation relevant to this game index.
    /// </summary>
    public required NamedApiResource Generation { get; set; }
  }
}