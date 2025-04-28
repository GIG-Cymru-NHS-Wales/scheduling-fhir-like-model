using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<AppointmentStatusId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<AppointmentStatusId>))]
public class AppointmentStatusId : StringIdValue
{
    public AppointmentStatusId()
    {

    }

    public AppointmentStatusId(string value) :
        base(value, 20, nameof(AppointmentStatusId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to AppointmentStatusId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator AppointmentStatusId(string value)
    {
        return new AppointmentStatusId(value);
    }

    /// <summary>
    /// Implicit conversion from AppointmentStatusId to string.
    /// </summary>
    /// <param name="id">The AppointmentStatusId instance to convert.</param>
    public static implicit operator string(AppointmentStatusId id)
    {
        return id?.UnderlyingValue!;
    }
}
