using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Enums;
[JsonConverter(typeof(LookupJsonConverter<string>))]
[TypeConverter(typeof(LookupTypeConverter<string, EventStatusEnum>))]
public record EventStatusEnum : Lookup<string>
{
    public EventStatusEnum(string id, string name, string definition)
        : base(id, name, definition) { }

    public static readonly EventStatusEnum Preparation = new("preparation", "preparation", "The core event has not started yet, but some staging activities have begun (e.g., surgical suite preparation).");
    public static readonly EventStatusEnum InProgress = new("in-progress", "inProgress", "The event is currently occurring.");
    public static readonly EventStatusEnum NotDone = new("not-done", "notDone", "The event was terminated prior to any activity beyond preparation.");
    public static readonly EventStatusEnum OnHold = new("on-hold", "onHold", "The event has been temporarily stopped but is expected to resume in the future.");
    public static readonly EventStatusEnum Stopped = new("stopped", "stopped", "The event was terminated prior to the full completion of the intended activity.");
    public static readonly EventStatusEnum Completed = new("completed", "completed", "The event has now concluded.");
    public static readonly EventStatusEnum EnteredInError = new("entered-in-error", "enteredInError", "This instance should not have been part of this patient's medical record.");
    public static readonly EventStatusEnum Unknown = new("unknown", "unknown", "The current state of the event is not known.");
}