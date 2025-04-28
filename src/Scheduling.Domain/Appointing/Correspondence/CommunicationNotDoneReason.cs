using NhsWales.Vaccination.Domain.Interfaces;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain.Appointing.Correspondence;
public class CommunicationNotDoneReason : BaseLookup<CommunicationNotDoneReasonId>
{
    public virtual ICollection<Communication>? Communications { get; set; }
}
