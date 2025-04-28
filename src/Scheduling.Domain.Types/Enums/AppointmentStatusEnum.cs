using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Enums;
[JsonConverter(typeof(LookupJsonConverter<string>))]
[TypeConverter(typeof(LookupTypeConverter<string, AppointmentStatusEnum>))]
public record AppointmentStatusEnum : Lookup<string>
{
    public string FriendlyName { get; set; }

    private AppointmentStatusEnum(string Id, string Code, string Name, string FriendlyName) : base(Id, Code, Name)
    {
        this.FriendlyName = FriendlyName;
    }
    public static readonly AppointmentStatusEnum Cancelled = new("cancelled", "cancelled", "Cancelled", "Cancelled");
    public static readonly AppointmentStatusEnum DNA = new("noshow", "noshow", "No Show", "DNA");
    public static readonly AppointmentStatusEnum Booked = new("booked", "booked", "Booked", "Not given");
    public static readonly AppointmentStatusEnum Fullfilled = new("fulfilled", "fullfilled", "Fullfilled", "Given");
    public static readonly AppointmentStatusEnum Arrived = new("arrived", "arrived", "Arrived", "Arrived");
    public static readonly AppointmentStatusEnum CheckedIn = new("checked-in", "checked-in", "Checked In", "Checked In");
    public static readonly AppointmentStatusEnum EnteredInError = new("entered-in-error", "entered-in-error", "Entered In Errror", "Entered In Error");
    public static readonly AppointmentStatusEnum Pending = new("pending", "pending", "Pending", "Pending");
    public static readonly AppointmentStatusEnum Proposed = new("proposed", "proposed", "Proposed", "Proposed");
    public static readonly AppointmentStatusEnum Waitlist = new("waitlist", "waitlist", "Waitlist", "Waitlist");

    /// <summary>
    /// This is a local value used to enable filtering.
    /// </summary>
    public static readonly AppointmentStatusEnum All = new("all", "all", "All", "All");


    public static implicit operator AppointmentStatusEnum(string index) => FromValue<AppointmentStatusEnum>(index);
    public static implicit operator string(AppointmentStatusEnum language) => language.Id;
}