using NhsWales.Scheduling.Domain.Abstractions;
using NhsWales.Vaccination.Domain.Interfaces;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain.OptOut;
public class FlagStatus : BaseLookup<FlagStatusId>
{
    public virtual ICollection<Suspense>? Suspenses { get; set; }
}
