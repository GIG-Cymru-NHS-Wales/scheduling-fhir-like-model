using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Values;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Vaccination.Domain.Types.Id;
/// <summary>
/// <see cref="WisNote"/> primary key.
/// </summary>
[TypeConverter(typeof(IntIdValueTypeConverter<ServiceTypeId>))]
[JsonConverter(typeof(IntIdValueJsonConverter<ServiceTypeId>))]
public partial class ServiceTypeId : IntIdValue
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceTypeId"/> class.
    /// </summary>
    public ServiceTypeId()
    {
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceTypeId"/> class.
    /// </summary>
    /// <param name="value">The value.</param>
    public ServiceTypeId(int value)
        : base(value)
    {
    }

    /// <summary>
    /// Implicit operator to allow us to map between the primitive type and this.
    /// </summary>
    /// <param name="value"></param>
    public static implicit operator ServiceTypeId(int value)
    {
        return new ServiceTypeId(value);
    }
}