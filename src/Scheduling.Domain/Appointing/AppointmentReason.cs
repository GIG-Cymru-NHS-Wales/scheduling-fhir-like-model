using NhsWales.Vaccination.Domain.Interfaces;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain.Appointing;
public class AppointmentReason : BaseLookup<AppointmentReasonId>
{
    public virtual ICollection<Appointment>? Appointments { get; set; }
}
