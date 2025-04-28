using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<FrequencyPatternId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<FrequencyPatternId>))]
public class FrequencyPatternId : StringIdValue
{
    public FrequencyPatternId()
    {

    }

    public FrequencyPatternId(string value) :
        base(value, 20, nameof(FrequencyPatternId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to AdverseReactionId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator FrequencyPatternId(string value)
    {
        return new FrequencyPatternId(value);
    }

    /// <summary>
    /// Implicit conversion from AdverseReactionId to string.
    /// </summary>
    /// <param name="id">The AdverseReactionId instance to convert.</param>
    public static implicit operator string(FrequencyPatternId id)
    {
        return id?.UnderlyingValue!;
    }
}
