using Lalapokeh.Models.API.Common;

namespace Lalapokeh.Models.API.Type
{
  /// <summary>
  /// Represents past type relations from previous generations.
  /// </summary>
  public class TypeRelationsPast
  {
    /// <summary>
    /// The last generation in which the referenced type had the listed damage relations.
    /// </summary>
    public required NamedApiResource Generation { get; set; }

    /// <summary>
    /// The damage relations the referenced type had up to and including the listed generation.
    /// </summary>
    public required TypeRelations DamageRelations { get; set; }
  }
}