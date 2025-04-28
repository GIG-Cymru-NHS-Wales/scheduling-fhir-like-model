using NhsWales.Vaccination.Domain.Interfaces;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain;
public class FrequencyPattern : BaseLookup<FrequencyPatternId>
{
    public virtual ICollection<Schedule>? Schedules { get; set; }
}
