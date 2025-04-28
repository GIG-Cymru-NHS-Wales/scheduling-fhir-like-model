using NhsWales.Vaccination.Domain.Interfaces;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain.OptOut;
public class FlagCategory : BaseLookup<FlagCategoryId>
{
    public virtual ICollection<Suspense>? Suspenses { get; set; }
}
