using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Ids;
[TypeConverter(typeof(StringIdValueTypeConverter<TargetDiseaseId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<TargetDiseaseId>))]
public class TargetDiseaseId : StringIdValue
{
    public TargetDiseaseId()
    {

    }

    public TargetDiseaseId(string value) :
        base(value, 18, nameof(TargetDiseaseId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to TargetDiseaseId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator TargetDiseaseId(string value)
    {
        return new TargetDiseaseId(value);
    }

    /// <summary>
    /// Implicit conversion from TargetDiseaseId to string.
    /// </summary>
    /// <param name="id">The TargetDiseaseId instance to convert.</param>
    public static implicit operator string(TargetDiseaseId id)
    {
        return id?.UnderlyingValue!;
    }
}
