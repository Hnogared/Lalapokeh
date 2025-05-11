using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Pokemon
{
  public class PokemonMove
  {
    /// <summary>
    /// The move the Pokémon can learn.
    /// </summary>
    public required NamedApiResource move;

    /// <summary>
    /// The details of the version in which the Pokémon can learn the move.
    /// </summary>
    public required List<PokemonMoveVersion> VersionGroupDetails;
  }
}