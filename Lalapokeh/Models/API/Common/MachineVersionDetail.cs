namespace Lalapokeh.Models.API.Common
{
  /// <summary>
  /// Represents details of a machine that teaches a move from an item, including the version group.
  /// </summary>
  public class MachineVersionDetail
  {
    /// <summary>
    /// The machine that teaches a move from an item.
    /// </summary>
    public required APIResource Machine { get; set; }

    /// <summary>
    /// The version group of this specific machine.
    /// </summary>
    public required NamedApiResource VersionGroup { get; set; }
  }
}
