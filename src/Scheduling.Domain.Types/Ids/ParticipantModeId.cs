using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<ParticipantModeId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<ParticipantModeId>))]
public class ParticipantModeId : StringIdValue
{
    public ParticipantModeId()
    {

    }

    public ParticipantModeId(string value) :
        base(value, 15, nameof(ParticipantModeId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to AdverseReactionId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator ParticipantModeId(string value)
    {
        return new ParticipantModeId(value);
    }

    /// <summary>
    /// Implicit conversion from AdverseReactionId to string.
    /// </summary>
    /// <param name="id">The AdverseReactionId instance to convert.</param>
    public static implicit operator string(ParticipantModeId id)
    {
        return id?.UnderlyingValue!;
    }
}
