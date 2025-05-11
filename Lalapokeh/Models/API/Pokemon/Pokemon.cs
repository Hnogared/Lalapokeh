using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Pokemon
{
  /// <summary>
  /// Represents a Pokémon and its attributes.
  /// </summary>
  public class Pokemon
  {
    /// <summary>
    /// The identifier for this Pokémon.
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// The name of this Pokémon.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// The base experience gained for defeating this Pokémon.
    /// </summary>
    public required int BaseExperience { get; set; }

    /// <summary>
    /// The height of this Pokémon in decimetres.
    /// </summary>
    public required int Height { get; set; }

    /// <summary>
    /// Whether this Pokémon is the default for its species.
    /// </summary>
    public required bool IsDefault { get; set; }

    /// <summary>
    /// Order for sorting. Almost national order, except families are grouped together.
    /// </summary>
    public required int Order { get; set; }

    /// <summary>
    /// The weight of this Pokémon in hectograms.
    /// </summary>
    public required int Weight { get; set; }

    /// <summary>
    /// The abilities this Pokémon could have.
    /// </summary>
    public required List<PokemonAbility> Abilities { get; set; }

    /// <summary>
    /// The forms this Pokémon can take on.
    /// </summary>
    public required List<NamedApiResource> Forms { get; set; }

    /// <summary>
    /// The game indices relevant to this Pokémon.
    /// </summary>
    public required List<VersionGameIndex> GameIndices { get; set; }

    /// <summary>
    /// The items this Pokémon may hold when encountered.
    /// </summary>
    public required List<PokemonHeldItem> HeldItems { get; set; }

    /// <summary>
    /// A link to location area encounters for this Pokémon.
    /// </summary>
    public required string LocationAreaEncounters { get; set; }

    /// <summary>
    /// The moves this Pokémon can learn.
    /// </summary>
    public required List<PokemonMove> Moves { get; set; }

    /// <summary>
    /// The past types this Pokémon had in previous generations.
    /// </summary>
    public required List<PokemonTypePast> PastTypes { get; set; }

    /// <summary>
    /// The past abilities this Pokémon had in previous generations.
    /// </summary>
    public required List<PokemonAbilityPast> PastAbilities { get; set; }

    /// <summary>
    /// The sprites associated with this Pokémon.
    /// </summary>
    public required PokemonSprites Sprites { get; set; }

    /// <summary>
    /// The cries associated with this Pokémon.
    /// </summary>
    public required PokemonCries Cries { get; set; }

    /// <summary>
    /// The species this Pokémon belongs to.
    /// </summary>
    public required NamedApiResource Species { get; set; }

    /// <summary>
    /// The base stats of this Pokémon.
    /// </summary>
    public required List<PokemonStat> Stats { get; set; }

    /// <summary>
    /// The types this Pokémon has.
    /// </summary>
    public required List<PokemonType> Types { get; set; }
  }
}