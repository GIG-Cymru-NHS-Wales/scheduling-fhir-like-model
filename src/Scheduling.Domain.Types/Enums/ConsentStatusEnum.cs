using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Enums
{
    [JsonConverter(typeof(LookupJsonConverter<string>))]
    [TypeConverter(typeof(LookupTypeConverter<string, ConsentStatusEnum>))]
    public record class ConsentStatusEnum : Lookup<string>
    {
        public ConsentStatusEnum(string id, string name, string definition)
     : base(id, name, definition) { }


        public static readonly ConsentStatusEnum Active = new ConsentStatusEnum("active", "Active", "The consent is to be followed and enforced.");

        public static readonly ConsentStatusEnum InActive = new ConsentStatusEnum("inactive", "Inactive", "The consent is terminated or replaced.");

        public static readonly ConsentStatusEnum NotDone = new ConsentStatusEnum("not-done", "Abandoned", "The consent development has been terminated prior to completion.");

        public static readonly ConsentStatusEnum Draft = new ConsentStatusEnum("draft", "Pending", "The consent is in development or awaiting use but is not yet intended to be acted upon.");

        public static readonly ConsentStatusEnum EnteredInError = new ConsentStatusEnum("entered-in-error", "Entered in Error", "The consent was created wrongly (e.g. wrong patient) and should be ignored.");

        public static readonly ConsentStatusEnum Unknown = new ConsentStatusEnum("unknown", "Unknown", "The resource is in an indeterminate state.");
        public static implicit operator ConsentStatusEnum(string index)  => FromValue<ConsentStatusEnum>(index);
        public static implicit operator string(ConsentStatusEnum method) => method.Id;

    }
}
