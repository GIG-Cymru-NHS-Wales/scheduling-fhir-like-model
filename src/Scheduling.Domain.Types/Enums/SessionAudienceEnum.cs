using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Enums;
[JsonConverter(typeof(LookupJsonConverter<string>))]
[TypeConverter(typeof(LookupTypeConverter<string, SessionAudienceEnum>))]
public record SessionAudienceEnum : Lookup<string>
{
    public SessionAudienceEnum(string id, string code, string name) : base(id, code, name) { }

    public static readonly SessionAudienceEnum PreschoolChildren = new("pre-school-children", "preSchoolChildren", "Pre-school Children");
    public static readonly SessionAudienceEnum SchoolChildren = new("school-aged-children", "schoolAgedChildren", "School-Aged Children");
    public static readonly SessionAudienceEnum Adults = new("adults", "adults", "Adults");
}