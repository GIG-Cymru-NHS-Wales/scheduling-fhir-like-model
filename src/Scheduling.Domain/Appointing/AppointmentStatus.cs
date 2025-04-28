using NhsWales.Scheduling.Domain.Abstractions;
using NhsWales.Vaccination.Domain.Interfaces;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain.Appointing;
public class AppointmentStatus : BaseLookup<AppointmentStatusId>
{
    public virtual ICollection<Appointment>? Appointments { get; set; }
}
