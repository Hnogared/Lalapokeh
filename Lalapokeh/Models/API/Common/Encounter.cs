namespace Lalapokeh.Models.API.Common
{
  /// <summary>
  /// Represents a Pokémon encounter, including level range and conditions.
  /// </summary>
  public class Encounter
  {
    /// <summary>
    /// The lowest level the Pokémon could be encountered at.
    /// </summary>
    public required int MinLevel { get; set; }

    /// <summary>
    /// The highest level the Pokémon could be encountered at.
    /// </summary>
    public required int MaxLevel { get; set; }

    /// <summary>
    /// A list of condition values that must be in effect for this encounter to occur.
    /// </summary>
    public required List<NamedApiResource> ConditionValues { get; set; }

    /// <summary>
    /// Percent chance that this encounter will occur.
    /// </summary>
    public required int Chance { get; set; }

    /// <summary>
    /// The method by which this encounter happens.
    /// </summary>
    public required NamedApiResource Method { get; set; }
  }
}