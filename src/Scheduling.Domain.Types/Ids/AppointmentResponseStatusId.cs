using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<AppointmentResponseStatusId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<AppointmentResponseStatusId>))]
public class AppointmentResponseStatusId : StringIdValue
{
    public AppointmentResponseStatusId()
    {

    }

    public AppointmentResponseStatusId(string value) :
        base(value, 16, nameof(AppointmentResponseStatusId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to AdverseReactionId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator AppointmentResponseStatusId(string value)
    {
        return new AppointmentResponseStatusId(value);
    }

    /// <summary>
    /// Implicit conversion from AdverseReactionId to string.
    /// </summary>
    /// <param name="id">The AdverseReactionId instance to convert.</param>
    public static implicit operator string(AppointmentResponseStatusId id)
    {
        return id?.UnderlyingValue!;
    }
}
