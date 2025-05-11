using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Stat
{
  /// <summary>
  /// Represents how a move affects a Pokémon's stat.
  /// </summary>
  public class MoveStatAffect
  {
    /// <summary>
    /// The maximum amount of change to the referenced stat.
    /// </summary>
    public required int Change { get; set; }

    /// <summary>
    /// The move causing the stat change.
    /// </summary>
    public required NamedApiResource Move { get; set; }
  }
}