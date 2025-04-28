using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Ids
{
    [TypeConverter(typeof(StringIdValueTypeConverter<ConsentCategoryId>))]
    [JsonConverter(typeof(StringIdValueJsonConverter<ConsentCategoryId>))]
    public class ConsentCategoryId : StringIdValue
    {
        public ConsentCategoryId()
        {

        }

        public ConsentCategoryId(string value)
            : base(value, 16, nameof(ConsentCategoryId))
        {
        }

        public static implicit operator ConsentCategoryId(string value)
        {
            return new ConsentCategoryId(value);
        }

        public static implicit operator string(ConsentCategoryId id)
        {
            return id?.UnderlyingValue!;
        }
    }
}
