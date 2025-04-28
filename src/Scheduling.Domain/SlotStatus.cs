using NhsWales.Vaccination.Domain.Interfaces;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain;
public class SlotStatus : BaseLookup<SlotStatusId>
{
    public virtual ICollection<Timeslot>? Timeslots { get; set; }
}
