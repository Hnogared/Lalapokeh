namespace Lalapokeh.Models.API.Common
{
  /// <summary>
  /// Represents encounter details for a specific game version, including the encounter specifics.
  /// </summary>
  public class VersionEncounterDetail
  {
    /// <summary>
    /// The game version this encounter happens in.
    /// </summary>
    public required NamedApiResource Version { get; set; }

    /// <summary>
    /// The total percentage of all encounter potential.
    /// </summary>
    public required int MaxChance { get; set; }

    /// <summary>
    /// A list of encounters and their specifics.
    /// </summary>
    public required List<Encounter> EncounterDetails { get; set; }
  }
}