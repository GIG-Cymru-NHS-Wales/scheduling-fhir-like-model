using NhsWales.Scheduling.Domain.Types.Ids;
using NhsWales.Vaccination.Domain.Interfaces;

namespace NhsWales.Scheduling.Domain;
public class SessionAudience : BaseLookup<SessionAudienceId>
{
    public virtual ICollection<Schedule>? Schedules { get; set; }
}
