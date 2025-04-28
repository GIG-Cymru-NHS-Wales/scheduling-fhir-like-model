using NhsWales.Scheduling.Domain.Types.Ids;
using NhsWales.Vaccination.Domain.Interfaces;

namespace NhsWales.Scheduling.Domain
{
    public class ConsentStatus : BaseLookup<ConsentStatusId>
    {
        public virtual ICollection<Consent>? Consents { get; set; }
    }
}
