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
[TypeConverter(typeof(LookupTypeConverter<string, AppointmentResponseStatusEnum>))]
public record AppointmentResponseStatusEnum : Lookup<string>
{
    public AppointmentResponseStatusEnum(string id, string name, string description)
        : base(id, name, description)
    {
    }

    public static readonly AppointmentResponseStatusEnum Accepted = new("accepted", "accepted", "The participant has accepted the appointment.");
    public static readonly AppointmentResponseStatusEnum Declined = new("declined", "declined", "The participant has declined the appointment and will not participate in the appointment.");
    public static readonly AppointmentResponseStatusEnum Tentative = new("tentative", "tentative", "The participant has tentatively accepted the appointment.");
    public static readonly AppointmentResponseStatusEnum NeedsAction = new("needs-action", "needsAction", "The participant needs to indicate whether they accept the appointment by changing this status to one of the other statuses.");
}