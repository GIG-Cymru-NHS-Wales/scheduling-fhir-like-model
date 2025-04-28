using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<AppointingMethodId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<AppointingMethodId>))]
public class AppointingMethodId : StringIdValue
{
    public AppointingMethodId()
    {

    }

    public AppointingMethodId(string value) :
        base(value, 16, nameof(AppointingMethodId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to AdverseReactionId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator AppointingMethodId(string value)
    {
        return new AppointingMethodId(value);
    }

    /// <summary>
    /// Implicit conversion from AdverseReactionId to string.
    /// </summary>
    /// <param name="id">The AdverseReactionId instance to convert.</param>
    public static implicit operator string(AppointingMethodId id)
    {
        return id?.UnderlyingValue!;
    }
}
