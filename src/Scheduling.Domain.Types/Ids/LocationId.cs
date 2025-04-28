using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NhsWales.Scheduling.Domain.Types.Ids;
[TypeConverter(typeof(StringIdValueTypeConverter<LocationId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<LocationId>))]
public class LocationId : StringIdValue
{
    public LocationId()
    {

    }

    public LocationId(string value) :
        base(value, 8, nameof(LocationId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to LocationId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator LocationId(string value)
    {
        return new LocationId(value);
    }

    /// <summary>
    /// Implicit conversion from LocationId to string.
    /// </summary>
    /// <param name="id">The LocationId instance to convert.</param>
    public static implicit operator string(LocationId id)
    {
        return id?.UnderlyingValue!;
    }
}
