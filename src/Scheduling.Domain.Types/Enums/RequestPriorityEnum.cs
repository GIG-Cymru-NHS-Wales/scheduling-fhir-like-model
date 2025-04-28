using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Enums;
[JsonConverter(typeof(LookupJsonConverter<string>))]
[TypeConverter(typeof(LookupTypeConverter<string, RequestPriorityEnum>))]
public record RequestPriorityEnum : Lookup<string>
{
    public RequestPriorityEnum(string id, string name, string description)
        : base(id, name, description)
    {
    }

    public static readonly RequestPriorityEnum Routine = new("routine", "routine", "The request has normal priority.");
    public static readonly RequestPriorityEnum Urgent = new("urgent", "urgent", "The request should be actioned promptly – higher priority than routine.");
    public static readonly RequestPriorityEnum Asap = new("asap", "asap", "The request should be actioned as soon as possible – urgent but not emergency.");
    public static readonly RequestPriorityEnum Stat = new("stat", "stat", "The request is time-critical and should be actioned immediately.");
}