using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Stat
{
  /// <summary>
  /// Represents how natures affect a Pokémon's stat.
  /// </summary>
  public class NatureStatAffectSets
  {
    /// <summary>
    /// A list of natures that increase the referenced stat.
    /// </summary>
    public required List<NamedApiResource> Increase { get; set; }

    /// <summary>
    /// A list of natures that decrease the referenced stat.
    /// </summary>
    public required List<NamedApiResource> Decrease { get; set; }
  }
}