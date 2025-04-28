using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NhsWales.Scheduling.Domain.Types.Enums;
[JsonConverter(typeof(LookupJsonConverter<string>))]
[TypeConverter(typeof(LookupTypeConverter<string, FlagCodeEnum>))]
public record FlagCodeEnum : Lookup<string>
{
    public FlagCodeEnum(string id, string code, string name) : base(id, code, name) { }

    public static readonly FlagCodeEnum Clinical = new("404684003", "clinical", "Clinical finding");
}
