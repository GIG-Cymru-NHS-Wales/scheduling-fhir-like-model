using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<FlagCategoryId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<FlagCategoryId>))]
public class FlagCategoryId : StringIdValue
{
    public FlagCategoryId()
    {

    }

    public FlagCategoryId(string value) :
        base(value, 18, nameof(FlagCategoryId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to AdverseReactionId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator FlagCategoryId(string value)
    {
        return new FlagCategoryId(value);
    }

    /// <summary>
    /// Implicit conversion from AdverseReactionId to string.
    /// </summary>
    /// <param name="id">The AdverseReactionId instance to convert.</param>
    public static implicit operator string(FlagCategoryId id)
    {
        return id?.UnderlyingValue!;
    }
}
