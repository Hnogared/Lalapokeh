using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Pokemon
{
  public class PokemonStat
  {
    /// <summary>
    /// The stat the Pokémon has.
    /// </summary>
    public required NamedApiResource stat;

    /// <summary>
    /// The effort points (EV) the Pokémon has in the stat.
    /// </summary>
    public required int effort;

    /// <summary>
    /// The base value of the stat.
    /// </summary>
    public required int BaseStat;
  }
}