using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Enums;

[JsonConverter(typeof(LookupJsonConverter<string>))]
[TypeConverter(typeof(LookupTypeConverter<string, AppointingMethodEnum>))]
public record AppointingMethodEnum : Lookup<string>
{
    public AppointingMethodEnum(string id, string code, string name) : base(id, code, name) { }

    public static readonly AppointingMethodEnum Timed = new("timed", "timed", "Session has time-based timselots.");
    public static readonly AppointingMethodEnum Untimed = new("untimed", "untimed", "Session has open drop-in timeslots.");

    public static implicit operator AppointingMethodEnum(string index) => FromValue<AppointingMethodEnum>(index);
    public static implicit operator string(AppointingMethodEnum method) => method.Id;
}