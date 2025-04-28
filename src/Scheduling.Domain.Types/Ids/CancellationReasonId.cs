using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<CancellationReasonId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<CancellationReasonId>))]
public class CancellationReasonId : StringIdValue
{
    public CancellationReasonId()
    {

    }

    public CancellationReasonId(string value) :
        base(value, 10, nameof(CancellationReasonId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to CancellationReasonId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator CancellationReasonId(string value)
    {
        return new CancellationReasonId(value);
    }

    /// <summary>
    /// Implicit conversion from CancellationReasonId to string.
    /// </summary>
    /// <param name="id">The CancellationReasonId instance to convert.</param>
    public static implicit operator string(CancellationReasonId id)
    {
        return id?.UnderlyingValue!;
    }
}
