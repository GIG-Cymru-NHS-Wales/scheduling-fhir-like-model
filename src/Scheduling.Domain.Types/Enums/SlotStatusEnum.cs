using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NhsWales.Scheduling.Domain.Types.Enums;
[JsonConverter(typeof(LookupJsonConverter<string>))]
[TypeConverter(typeof(LookupTypeConverter<string, SlotStatusEnum>))]
public record SlotStatusEnum : Lookup<string>
{
    public SlotStatusEnum(string id, string code, string name)
        : base(id, code, name) { }

    public static readonly SlotStatusEnum Free = new("free", "free", "The slot is available.");
    public static readonly SlotStatusEnum Busy = new("busy", "busy", "The slot is busy because one or more events have been scheduled for that time.");
    public static readonly SlotStatusEnum BusyUnavailable = new("busy-unavailable", "unavailable", "The slot is busy and not available for scheduling.");
    public static readonly SlotStatusEnum BusyTentative = new("busy-tentative", "tentative", "The slot is busy but may be available for scheduling.");
    public static readonly SlotStatusEnum EnteredInError = new("entered-in-error", "enteredInError", "This instance should not have been part of this patient's medical record.");
    
    public static implicit operator SlotStatusEnum(string index) => FromValue<SlotStatusEnum>(index);
    public static implicit operator string(SlotStatusEnum status) => status.Id;
}