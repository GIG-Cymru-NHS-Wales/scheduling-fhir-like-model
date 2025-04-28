using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Ids
{
    [TypeConverter(typeof(StringIdValueTypeConverter<ConsentStatusId>))]
    [JsonConverter(typeof(StringIdValueJsonConverter<ConsentStatusId>))]
    public class ConsentStatusId : StringIdValue
    {

        public ConsentStatusId()
        {
        }

        public ConsentStatusId(string value) :
            base(value, 16, nameof(ConsentStatusId))
        {
        }
        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="ConsentStatusId"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ConsentStatusId(string value)
        {
            return new ConsentStatusId(value);
        }
        /// <summary>
        /// Performs an implicit conversion from <see cref="ConsentStatusId"/> to <see cref="System.String"/>.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator string(ConsentStatusId id)
        {
            return id?.UnderlyingValue!;
        }
    }
}
