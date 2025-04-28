
using NhsWales.Scheduling.Domain.Types.Ids;
using NhsWales.Vaccination.Domain.Interfaces;

namespace NhsWales.Scheduling.Domain
{
    public class ConsentCategory : BaseLookup<ConsentCategoryId>
    {
        public virtual ICollection<Consent>? Consents { get; set; }
    }
}
