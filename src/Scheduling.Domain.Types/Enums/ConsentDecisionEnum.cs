using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using System.ComponentModel;
using System.Text.Json.Serialization;


namespace NhsWales.Scheduling.Domain.Types.Enums
{
    [JsonConverter(typeof(LookupJsonConverter<string>))]
    [TypeConverter(typeof(LookupTypeConverter<string, ConsentDecisionEnum>))]
    public record class ConsentDecisionEnum : Lookup<string>
    {
        public ConsentDecisionEnum(string id, string name, string definition)
            : base(id, name, definition)
        {
        }

        public static readonly ConsentDecisionEnum Deny = new ConsentDecisionEnum("deny","deny","Consent is denied for actions meeting these rules.");
        public static readonly ConsentDecisionEnum Permit = new ConsentDecisionEnum("permit","permit","Consent is provided for actions meeting these rules.");
    }
}