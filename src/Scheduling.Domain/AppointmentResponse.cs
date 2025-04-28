using NhsWales.CommunityCommon.Domain.Types;
using NhsWales.Scheduling.Domain.Appointing;
using NhsWales.Vaccination.Domain.Types.Id;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhsWales.Scheduling.Domain;
public class AppointmentResponse
{
    public required Guid Id { get; set; }
    public required Guid AppointmentId { get; set; }
    public bool? ProposedNewTime { get; set; }
    public DateTime? Start { get; set; }
    public DateTime? End { get; set; }
    public required AppointmentResponseStatusId AppointmentResponseStatusId { get; set; }
    public required ConcurrencyToken ConcurrencyToken { get; set; }

    public virtual Appointment? Appointment { get; set; }
    public virtual AppointmentResponseStatus? AppointmentResponseStatus { get; set; }
}
