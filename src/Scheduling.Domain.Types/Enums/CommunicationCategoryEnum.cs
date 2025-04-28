using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Enums;
[JsonConverter(typeof(LookupJsonConverter<string>))]
[TypeConverter(typeof(LookupTypeConverter<string, CommunicationCategoryEnum>))]
public record CommunicationCategoryEnum : Lookup<string>
{
    public CommunicationCategoryEnum(string id, string name, string description)
        : base(id, name, description)
    {
    }

    public static readonly CommunicationCategoryEnum Alert = new("alert", "alert", "General alerts or notifications.");
    public static readonly CommunicationCategoryEnum Reminder = new("reminder", "reminder", "Reminders for appointments or follow-ups.");
    public static readonly CommunicationCategoryEnum Notification = new("notification", "notification", "Non-urgent notifications.");
    public static readonly CommunicationCategoryEnum Instruction = new("instruction", "instruction", "Specific instructions or guidelines.");
    public static readonly CommunicationCategoryEnum Referral = new("referral", "referral", "Information related to patient referrals.");
    public static readonly CommunicationCategoryEnum ProgressUpdate = new("progress-update", "progress Update", "Updates on patient progress or status.");
}
