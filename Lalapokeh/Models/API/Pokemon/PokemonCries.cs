namespace Lalapokeh.Models.API.Pokemon
{
  public class PokemonCries
  {
    /// <summary>
    /// The latest depiction of this Pokémon's cry.
    /// </summary>
    public required string latest;

    /// <summary>
    /// The legacy depiction of this Pokémon's cry.
    /// </summary>
    public required string legacy;
  }
}