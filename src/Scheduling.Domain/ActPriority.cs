using NhsWales.Vaccination.Domain.Interfaces;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain;
public class ActPriority : BaseLookup<ActPriorityId>
{
    public virtual ICollection<Appointment>? Appointments { get; set; }
}
