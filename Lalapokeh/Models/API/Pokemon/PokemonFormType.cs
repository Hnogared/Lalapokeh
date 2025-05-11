using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Pokemon
{
  public class PokemonFormType
  {
    /// <summary>
    /// The order the Pokémon's types are listed in.
    /// </summary>
    public required int Slot;

    /// <summary>
    /// The type the referenced Form has.
    /// </summary>
    public required NamedApiResource type;
  }
}