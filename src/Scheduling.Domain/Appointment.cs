using NhsWales.CommunityCommon.Domain.Types;
using NhsWales.CommunityCommon.Domain.Types.Patient;
using NhsWales.Scheduling.Domain.Appointing;
using NhsWales.Scheduling.Domain.Appointing.Correspondence;
using NhsWales.Scheduling.Domain.Types.Ids;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain;
public class Appointment
{
    public required Guid Id { get; set; }
    public required NhsNumber PatientNhsNumber { get; set; }
    public required AppointmentStatusId AppointmentStatusId { get; set; }
    public CancellationReasonId? CancellationReasonId { get; set; }
    public required ServiceTypeId ServiceTypeId { get; set; }
    public required AppointmentReasonId AppointmentReasonId { get; set; }
    public Guid? RecommendationId { get; set; }
    public ActPriorityId? ActPriorityId { get; set; }
    public string? Description { get; set; }
    public Guid? ReplacesId { get; set; }
    public required DateTime Created { get; set; }
    public DateTime? CancellationDate { get; set; }
    public string? Note { get; set; }
    public required ConcurrencyToken ConcurrencyToken { get; set; }
    public required SystemUriId SourceSystemId { get; set; }
    public Guid? TimeslotId { get; set; }


    public virtual AppointmentStatus? AppointmentStatus { get; set; }
    public virtual CancellationReason? CancellationReason { get; set; }
    public virtual ServiceType? ServiceType { get; set; }
    public virtual AppointmentReason? AppointmentReason { get; set; }
    public virtual ActPriority? ActPriority { get; set; }
    public virtual Appointment? Replaces { get; set; }
    public virtual Timeslot? Timeslot { get; set; }
    public virtual AppointmentResponse? AppointmentResponse { get; set; }

    public virtual ICollection<Communication>? Communications { get; set; }
}
