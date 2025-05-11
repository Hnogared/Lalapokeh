using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Stat
{
  /// <summary>
  /// Represents a Pokémon stat and its attributes.
  /// </summary>
  public class Stat
  {
    /// <summary>
    /// The identifier for this stat.
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// The name of this stat.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// ID used by the games for this stat.
    /// </summary>
    public required int GameIndex { get; set; }

    /// <summary>
    /// Whether this stat only exists within a battle.
    /// </summary>
    public required bool IsBattleOnly { get; set; }

    /// <summary>
    /// A detail of moves that affect this stat positively or negatively.
    /// </summary>
    public required MoveStatAffectSets AffectingMoves { get; set; }

    /// <summary>
    /// A detail of natures that affect this stat positively or negatively.
    /// </summary>
    public required NatureStatAffectSets AffectingNatures { get; set; }

    /// <summary>
    /// A list of characteristics set on a Pokémon when its highest base stat is this stat.
    /// </summary>
    public required List<ApiResource> Characteristics { get; set; }

    /// <summary>
    /// The class of damage this stat is directly related to.
    /// </summary>
    public required NamedApiResource MoveDamageClass { get; set; }

    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    public required List<ApiName> Names { get; set; }
  }
}