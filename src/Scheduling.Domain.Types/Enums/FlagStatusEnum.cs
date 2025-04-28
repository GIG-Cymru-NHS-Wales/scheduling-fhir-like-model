using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Enums;
[JsonConverter(typeof(LookupJsonConverter<string>))]
[TypeConverter(typeof(LookupTypeConverter<string, FlagStatusEnum>))]
public record FlagStatusEnum : Lookup<string>
{
    public FlagStatusEnum(string id, string code, string name) : base(id, code, name) { }

    public static readonly FlagStatusEnum Active = new("active", "active", "Active");
    public static readonly FlagStatusEnum Inactive = new("inactive", "inactive", "Inactive");
    public static readonly FlagStatusEnum EnteredInError = new("entered-in-error", "entered-in-error", "Entered in Error");
}