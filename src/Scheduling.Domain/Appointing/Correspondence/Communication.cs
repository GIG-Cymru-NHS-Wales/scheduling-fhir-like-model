using NhsWales.CommunityCommon.Domain.Types;
using NhsWales.CommunityCommon.Domain.Types.Patient;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain.Appointing.Correspondence;
public class Communication
{
    public required Guid Id { get; set; }
    public required EventStatusId StatusId { get; set; }
    public CommunicationNotDoneReasonId? StatusReasonId { get; set; }
    public CommunicationCategoryId? CommunicationCategoryId { get; set; }
    public RequestPriorityId? PriorityId { get; set; }
    public required ParticipantModeId MediumId { get; set; }
    public required NhsNumber PatientNhsNumber { get; set; }
    public CommunicationTopicId? TopicId { get; set; }
    public required long EmsgId { get; set; }
    public required Guid AppointmentId { get; set; }
    public DateTime? Sent { get; set; }
    public string? Note { get; set; }
    public required ConcurrencyToken ConcurrencyToken { get; set; }

    public virtual Appointment? Appointment { get; set; }
    public virtual EventStatus? EventStatus { get; set; }
    public virtual CommunicationNotDoneReason? StatusReason { get; set; }
    public virtual CommunicationCategory? CommunicationCategory { get; set; }
    public virtual RequestPriority? Priority { get; set; }
    public virtual ParticipantMode? Medium { get; set; }
    public virtual CommunicationTopic? Topic { get; set; }
}
