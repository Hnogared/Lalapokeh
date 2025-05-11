namespace Lalapokeh.Models.API.Stat
{
  /// <summary>
  /// Represents a set of moves and how they affect a Pokémon's stat.
  /// </summary>
  public class MoveStatAffectSets
  {
    /// <summary>
    /// A list of moves that increase the referenced stat.
    /// </summary>
    public required List<MoveStatAffect> Increase { get; set; }

    /// <summary>
    /// A list of moves that decrease the referenced stat.
    /// </summary>
    public required List<MoveStatAffect> Decrease { get; set; }
  }
}