using NhsWales.Vaccination.Domain.Interfaces;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain;
public class CancellationReason : BaseLookup<CancellationReasonId>
{
    public virtual ICollection<Appointment>? Appointments { get; set; }
}
