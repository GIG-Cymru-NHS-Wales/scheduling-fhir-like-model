using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Enums;
[JsonConverter(typeof(LookupJsonConverter<string>))]
[TypeConverter(typeof(LookupTypeConverter<string, FlagCategoryEnum>))]
public record FlagCategoryEnum : Lookup<string>
{
    public FlagCategoryEnum(string id, string code, string name) : base(id, code, name) { }

    public static readonly FlagCategoryEnum Clinical = new("clinical", "clinical", "Clinical");
    public static readonly FlagCategoryEnum Administrative = new("administrative", "administrative", "Administrative");
    public static readonly FlagCategoryEnum Behavioral = new("behavioral", "behavioral", "Behavioral");
    public static readonly FlagCategoryEnum Research = new("research", "research", "Research");
    public static readonly FlagCategoryEnum AdvanceDirective = new("advance-directive", "advance-directive", "Advance Directive");
    public static readonly FlagCategoryEnum Safety = new("safety", "safety", "Safety");
}
