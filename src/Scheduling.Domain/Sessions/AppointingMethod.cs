using NhsWales.Vaccination.Domain.Interfaces;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain;
public class AppointingMethod : BaseLookup<AppointingMethodId>
{
    public virtual ICollection<Schedule>? Schedules { get; set; }
}
