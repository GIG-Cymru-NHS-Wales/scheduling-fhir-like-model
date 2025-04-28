using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<RequestPriorityId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<RequestPriorityId>))]
public class RequestPriorityId : StringIdValue
{
    public RequestPriorityId()
    {

    }

    public RequestPriorityId(string value) :
        base(value, 10, nameof(RequestPriorityId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to AdverseReactionId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator RequestPriorityId(string value)
    {
        return new RequestPriorityId(value);
    }

    /// <summary>
    /// Implicit conversion from AdverseReactionId to string.
    /// </summary>
    /// <param name="id">The AdverseReactionId instance to convert.</param>
    public static implicit operator string(RequestPriorityId id)
    {
        return id?.UnderlyingValue!;
    }
}
