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
[TypeConverter(typeof(LookupTypeConverter<string, CommunicationNotDoneReasonEnum>))]
public record CommunicationNotDoneReasonEnum : Lookup<string>
{
    public CommunicationNotDoneReasonEnum(string id, string name, string description)
        : base(id, name, description)
    {
    }


    public static readonly CommunicationNotDoneReasonEnum Unknown = new("unknown", "unknown", "The communication was not done due to an unknown reason.");
    public static readonly CommunicationNotDoneReasonEnum SystemError = new("system-error", "systemError", "The communication was not done due to a system error.");
    public static readonly CommunicationNotDoneReasonEnum InvalidPhoneNumber = new("invalid-phone-number", "invalidPhoneNumber", "The communication was not done due to an invalid phone number.");
    public static readonly CommunicationNotDoneReasonEnum RecipientUnavailable = new("recipient-unavailable", "recipientUnavailable", "The communication was not done due to the recipient being unavailable.");
    public static readonly CommunicationNotDoneReasonEnum FamilyObjection = new("family-objection", "familyObjection", "The communication was not done due to a family objection.");
    public static readonly CommunicationNotDoneReasonEnum PatientObjection = new("patient-objection", "patientObjection", "The communication was not done due to a patient objection.");
}