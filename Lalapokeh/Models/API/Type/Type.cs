using Lalapokeh.Models.API.Common;
using Lalapokeh.Models.API.Interfaces;

namespace Lalapokeh.Models.API.Type
{
  /// <summary>
  /// Represents a Pokémon type and its attributes.
  /// </summary>
  public class Type : IIndexApiResource, INameApiResource
  {
    /// <summary>
    /// The identifier for this type.
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// The name of this type.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// A detail of how effective this type is toward others and vice versa.
    /// </summary>
    public required TypeRelations DamageRelations { get; set; }

    /// <summary>
    /// A list of details of how effective this type was toward others and vice versa in previous generations.
    /// </summary>
    public required List<TypeRelationsPast> PastDamageRelations { get; set; }

    /// <summary>
    /// A list of game indices relevant to this item by generation.
    /// </summary>
    public required List<GenerationGameIndex> GameIndices { get; set; }

    /// <summary>
    /// The generation this type was introduced in.
    /// </summary>
    public required NamedApiResource Generation { get; set; }

    /// <summary>
    /// The class of damage inflicted by this type.
    /// </summary>
    public required NamedApiResource MoveDamageClass { get; set; }

    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    public required List<ApiName> Names { get; set; }

    /// <summary>
    /// A list of details of Pokémon that have this type.
    /// </summary>
    public required List<TypePokemon> Pokemon { get; set; }

    /// <summary>
    /// A list of moves that have this type.
    /// </summary>
    public required List<NamedApiResource> Moves { get; set; }
  }
}