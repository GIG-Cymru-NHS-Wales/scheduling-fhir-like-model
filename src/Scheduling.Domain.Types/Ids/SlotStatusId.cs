using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<SlotStatusId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<SlotStatusId>))]
public class SlotStatusId : StringIdValue
{
    public SlotStatusId()
    {

    }

    public SlotStatusId(string value) :
        base(value, 16, nameof(SlotStatusId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to AdverseReactionId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator SlotStatusId(string value)
    {
        return new SlotStatusId(value);
    }

    /// <summary>
    /// Implicit conversion from AdverseReactionId to string.
    /// </summary>
    /// <param name="id">The AdverseReactionId instance to convert.</param>
    public static implicit operator string(SlotStatusId id)
    {
        return id?.UnderlyingValue!;
    }
}
