using NhsWales.CommunityCommon.Domain.Types;
using NhsWales.Scheduling.Domain.Appointing;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain;
public class Timeslot
{
    public Guid? Id { get; set; }
    public required AppointmentReasonId AppointmentReasonId { get; set; }
    public required SlotStatusId SlotStatusId { get; set; }
    public required DateTime Start { get; set; }
    public required DateTime End { get; set; }
    public required bool Overbooked { get; set; }
    public Guid? ScheduleId { get; set; }
    public ConcurrencyToken? ConcurrencyToken { get; set; }

    public virtual Appointment? Appointment { get; set; }
    public virtual AppointmentReason? AppointmentReason { get; set; }
    public virtual SlotStatus? SlotStatus { get; set; }
    public virtual Schedule? Schedule { get; set; }
}
