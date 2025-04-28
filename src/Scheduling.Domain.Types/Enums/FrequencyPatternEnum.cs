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
[TypeConverter(typeof(LookupTypeConverter<string, FrequencyPatternEnum>))]
public record FrequencyPatternEnum : Lookup<string>
{
    public FrequencyPatternEnum(string id, string name, string description)
        : base(id, name, description)
    {
    }

    //public static readonly FrequencyPatternEnum Daily = new("daily", "daily", "Repeat daily");
    public static readonly FrequencyPatternEnum Weekly = new("weekly", "weekly", "Repeat weekly");
    //public static readonly FrequencyPatternEnum Monthly = new("monthly", "monthly", "Occurs every month.");
    //public static readonly FrequencyPatternEnum Yearly = new("yearly", "yearly", "Occurs every year.");
    public static readonly FrequencyPatternEnum Fortnightly = new("fortnightly", "fortnightly", "Repeat fortnightly");
    public static readonly FrequencyPatternEnum DoNotRepeat = new("do-not-repeat", "do not repeat", "Do not repeat");

    public static implicit operator FrequencyPatternEnum(string index) => FromValue<FrequencyPatternEnum>(index);
    public static implicit operator string(FrequencyPatternEnum pattern) => pattern.Id;
}
