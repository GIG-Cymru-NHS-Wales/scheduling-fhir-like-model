using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<FlagStatusId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<FlagStatusId>))]
public class FlagStatusId : StringIdValue
{
    public FlagStatusId()
    {

    }

    public FlagStatusId(string value) :
        base(value, 16, nameof(FlagStatusId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to AdverseReactionId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator FlagStatusId(string value)
    {
        return new FlagStatusId(value);
    }

    /// <summary>
    /// Implicit conversion from AdverseReactionId to string.
    /// </summary>
    /// <param name="id">The AdverseReactionId instance to convert.</param>
    public static implicit operator string(FlagStatusId id)
    {
        return id?.UnderlyingValue!;
    }
}
