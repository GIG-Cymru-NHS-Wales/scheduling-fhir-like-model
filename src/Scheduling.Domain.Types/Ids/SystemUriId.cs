using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Ids;

[TypeConverter(typeof(StringIdValueTypeConverter<SystemUriId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<SystemUriId>))]
public class SystemUriId : StringIdValue
{
    public SystemUriId()
    {

    }

    public SystemUriId(string value) :
        base(value, 100, nameof(SystemUriId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to SystemUriId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator SystemUriId(string value)
    {
        return new SystemUriId(value);
    }

    /// <summary>
    /// Implicit conversion from SystemUriId to string.
    /// </summary>
    /// <param name="id">The SystemUriId instance to convert.</param>
    public static implicit operator string(SystemUriId id)
    {
        return id?.UnderlyingValue!;
    }
}
