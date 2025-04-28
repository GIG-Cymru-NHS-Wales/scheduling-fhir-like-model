using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<CommunicationNotDoneReasonId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<CommunicationNotDoneReasonId>))]
public class CommunicationNotDoneReasonId : StringIdValue
{
    public CommunicationNotDoneReasonId()
    {

    }

    public CommunicationNotDoneReasonId(string value) :
        base(value, 25, nameof(CommunicationNotDoneReasonId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to AdverseReactionId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator CommunicationNotDoneReasonId(string value)
    {
        return new CommunicationNotDoneReasonId(value);
    }

    /// <summary>
    /// Implicit conversion from AdverseReactionId to string.
    /// </summary>
    /// <param name="id">The AdverseReactionId instance to convert.</param>
    public static implicit operator string(CommunicationNotDoneReasonId id)
    {
        return id?.UnderlyingValue!;
    }
}
