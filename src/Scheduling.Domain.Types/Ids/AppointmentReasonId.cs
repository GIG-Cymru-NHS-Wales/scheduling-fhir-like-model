using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<AppointmentReasonId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<AppointmentReasonId>))]
public class AppointmentReasonId : StringIdValue
{
    public AppointmentReasonId()
    {

    }

    public AppointmentReasonId(string value) :
        base(value, 10, nameof(AppointmentReasonId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to AdverseReactionId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator AppointmentReasonId(string value)
    {
        return new AppointmentReasonId(value);
    }

    /// <summary>
    /// Implicit conversion from AdverseReactionId to string.
    /// </summary>
    /// <param name="id">The AdverseReactionId instance to convert.</param>
    public static implicit operator string(AppointmentReasonId id)
    {
        return id?.UnderlyingValue!;
    }
}
