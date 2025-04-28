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
[TypeConverter(typeof(LookupTypeConverter<string, CommunicationTopicEnum>))]
public record CommunicationTopicEnum : Lookup<string>
{
    public CommunicationTopicEnum(string id, string name, string description)
        : base(id, name, description)
    {
    }

    public static readonly CommunicationTopicEnum Prescription = new("prescription", "prescription", "Information about a prescription.");
    public static readonly CommunicationTopicEnum Appointment = new("appointment", "appointment", "Information about an appointment.");
    public static readonly CommunicationTopicEnum Report = new("report", "report", "Information about a report or test results.");
    public static readonly CommunicationTopicEnum Reminder = new("reminder", "reminder", "General reminders or follow-up notices.");
    public static readonly CommunicationTopicEnum Alert = new("alert", "alert", "Critical health alerts or notifications.");
    public static readonly CommunicationTopicEnum Instruction = new("instruction", "instruction", "Specific instructions or guidelines for a patient.");
}