using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<CommunicationTopicId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<CommunicationTopicId>))]
public class CommunicationTopicId : StringIdValue
{
    public CommunicationTopicId()
    {

    }

    public CommunicationTopicId(string value) :
        base(value, 30, nameof(CommunicationTopicId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to AdverseReactionId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator CommunicationTopicId(string value)
    {
        return new CommunicationTopicId(value);
    }

    /// <summary>
    /// Implicit conversion from AdverseReactionId to string.
    /// </summary>
    /// <param name="id">The AdverseReactionId instance to convert.</param>
    public static implicit operator string(CommunicationTopicId id)
    {
        return id?.UnderlyingValue!;
    }
}
