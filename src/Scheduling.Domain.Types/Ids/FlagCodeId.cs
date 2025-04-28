using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<FlagCodeId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<FlagCodeId>))]
public class FlagCodeId : StringIdValue
{
    public FlagCodeId()
    {

    }

    public FlagCodeId(string value) :
        base(value, 18, nameof(FlagCodeId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to AdverseReactionId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator FlagCodeId(string value)
    {
        return new FlagCodeId(value);
    }

    /// <summary>
    /// Implicit conversion from AdverseReactionId to string.
    /// </summary>
    /// <param name="id">The AdverseReactionId instance to convert.</param>
    public static implicit operator string(FlagCodeId id)
    {
        return id?.UnderlyingValue!;
    }
}
