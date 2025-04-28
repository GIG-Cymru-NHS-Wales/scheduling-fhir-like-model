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
[TypeConverter(typeof(StringIdValueTypeConverter<SessionAudienceId>))]
[JsonConverter(typeof(StringIdValueJsonConverter<SessionAudienceId>))]
public class SessionAudienceId : StringIdValue
{
    public SessionAudienceId()
    {

    }

    public SessionAudienceId(string value) :
        base(value, 25, nameof(SessionAudienceId))
    {

    }

    /// <summary>
    /// Implicit conversion from string to SessionAudienceId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator SessionAudienceId(string value)
    {
        return new SessionAudienceId(value);
    }

    /// <summary>
    /// Implicit conversion from SessionAudienceId to string.
    /// </summary>
    /// <param name="id">The SessionAudienceId instance to convert.</param>
    public static implicit operator string(SessionAudienceId id)
    {
        return id?.UnderlyingValue!;
    }
}
