using NhsWales.Vaccination.Domain.Interfaces;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain;
public class ServiceType : BaseLookup<ServiceTypeId>
{
    public virtual ICollection<Appointment>? Appointments { get; set; }
    public virtual ICollection<Schedule>? Schedules { get; set; }
}
