using NhsWales.Vaccination.Domain.Interfaces;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain.OptOut;
public class FlagCode : BaseLookup<FlagCodeId>
{
    public virtual ICollection<Suspense>? Suspenses { get; set; }
}
