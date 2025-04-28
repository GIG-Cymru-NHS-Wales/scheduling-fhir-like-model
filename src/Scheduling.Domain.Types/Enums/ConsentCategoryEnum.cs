using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Enums
{

    [JsonConverter(typeof(LookupJsonConverter<string>))]
    [TypeConverter(typeof(LookupTypeConverter<string, ConsentCategoryEnum>))]
    public record class ConsentCategoryEnum : Lookup<string>
    {
        public ConsentCategoryEnum(string id, string name, string definition)
     : base(id, name, definition) { }

        public static readonly ConsentCategoryEnum Treatment = new ConsentCategoryEnum("treatment", "treatment", "Consent to undergo a specific treatment");

        public static readonly ConsentCategoryEnum PatientPrivacy = new ConsentCategoryEnum("patient-privacy", "patient privacy", "Agreement to collect, access, use or disclose (share) information");

    }
}
