using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<ActPriorityId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<ActPriorityId>))]
public class ActPriorityId : StringIdValue
{
    public ActPriorityId()
    {

    }

    public ActPriorityId(string value) :
        base(value, 4, nameof(ActPriorityId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to AdverseReactionId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator ActPriorityId(string value)
    {
        return new ActPriorityId(value);
    }

    /// <summary>
    /// Implicit conversion from AdverseReactionId to string.
    /// </summary>
    /// <param name="id">The AdverseReactionId instance to convert.</param>
    public static implicit operator string(ActPriorityId id)
    {
        return id?.UnderlyingValue!;
    }
}
