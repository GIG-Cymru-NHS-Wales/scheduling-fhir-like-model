using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;

[TypeConverter(typeof(StringIdValueTypeConverter<CommunicationCategoryId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<CommunicationCategoryId>))]
public class CommunicationCategoryId : StringIdValue
{
    public CommunicationCategoryId()
    {

    }

    public CommunicationCategoryId(string value) :
        base(value, 15, nameof(CommunicationCategoryId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to AdverseReactionId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator CommunicationCategoryId(string value)
    {
        return new CommunicationCategoryId(value);
    }

    /// <summary>
    /// Implicit conversion from AdverseReactionId to string.
    /// </summary>
    /// <param name="id">The AdverseReactionId instance to convert.</param>
    public static implicit operator string(CommunicationCategoryId id)
    {
        return id?.UnderlyingValue!;
    }
}
