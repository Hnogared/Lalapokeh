using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Pokemon
{
  public class PokemonMoveVersion
  {
    /// <summary>
    /// The method by which the move is learned.
    /// </summary>
    public required NamedApiResource MoverLearnMethod;

    /// <summary>
    /// The version group in which the move is learned.
    /// </summary>
    public required NamedApiResource VersionGroup;

    /// <summary>
    /// The minimum level to learn the move.
    /// </summary>
    public required int LevelLearnedAt;

    /// <summary>
    /// Order by which the Pokémon will learn the move.
    /// A newly learnt move will replace the move with lowest order.
    /// </summary>
    public required int Order;
  }
}