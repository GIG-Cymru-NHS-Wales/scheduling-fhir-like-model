using NhsWales.Scheduling.Domain.Abstractions;
using NhsWales.Scheduling.Domain.Types.Ids;

namespace NhsWales.Scheduling.Domain.OptOut;
public class Suspense : Flag
{
    public required TargetDiseaseId TargetDiseaseId { get; set; }
    public required DateTime DateRecorded { get; set; }
}
   
