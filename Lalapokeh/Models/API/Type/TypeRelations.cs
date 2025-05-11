using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Type
{
  /// <summary>
  /// Represents how a Pokémon type interacts with other types.
  /// </summary>
  public class TypeRelations
  {
    /// <summary>
    /// Types this type has no effect on.
    /// </summary>
    public required List<NamedApiResource> NoDamageTo { get; set; }

    /// <summary>
    /// Types this type is not very effective against.
    /// </summary>
    public required List<NamedApiResource> HalfDamageTo { get; set; }

    /// <summary>
    /// Types this type is very effective against.
    /// </summary>
    public required List<NamedApiResource> DoubleDamageTo { get; set; }

    /// <summary>
    /// Types that have no effect on this type.
    /// </summary>
    public required List<NamedApiResource> NoDamageFrom { get; set; }

    /// <summary>
    /// Types that are not very effective against this type.
    /// </summary>
    public required List<NamedApiResource> HalfDamageFrom { get; set; }

    /// <summary>
    /// Types that are very effective against this type.
    /// </summary>
    public required List<NamedApiResource> DoubleDamageFrom { get; set; }
  }
}