using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Enums;
[JsonConverter(typeof(LookupJsonConverter<string>))]
[TypeConverter(typeof(LookupTypeConverter<string, ActPriorityEnum>))]
public record ActPriorityEnum : Lookup<string>
{
    public ActPriorityEnum(string id, string code, string name) : base(id, code, name) { }

    public static readonly ActPriorityEnum AsSoonAsPossible = new("ASAP", "asap", "As soon as possible, next possible slot.");
    public static readonly ActPriorityEnum Callback = new("CB", "callback", "Callback.");
    public static readonly ActPriorityEnum Emergency = new("EM", "emergency", "Emergency.");
    public static readonly ActPriorityEnum Preoperative = new("P", "preoperative", "Preoperative (priority 4).");
    public static readonly ActPriorityEnum Routine = new("R", "routine", "Routine.");
    public static readonly ActPriorityEnum Scheduled = new("S", "scheduled", "Scheduled.");
    public static readonly ActPriorityEnum PreopPriorToTherapeutic = new("T", "preop", "Timing critical (priority 5).");
    public static readonly ActPriorityEnum Urgent = new("U", "urgent", "Urgent.");
    public static readonly ActPriorityEnum CallbackForTestResults = new("UR", "callback", "Urgent for test results.");
}
