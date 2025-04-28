using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<EventStatusId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<EventStatusId>))]
public class EventStatusId : StringIdValue
{
    public EventStatusId()
    {

    }

    public EventStatusId(string value) :
        base(value, 20, nameof(EventStatusId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to AdverseReactionId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator EventStatusId(string value)
    {
        return new EventStatusId(value);
    }

    /// <summary>
    /// Implicit conversion from AdverseReactionId to string.
    /// </summary>
    /// <param name="id">The AdverseReactionId instance to convert.</param>
    public static implicit operator string(EventStatusId id)
    {
        return id?.UnderlyingValue!;
    }
}
