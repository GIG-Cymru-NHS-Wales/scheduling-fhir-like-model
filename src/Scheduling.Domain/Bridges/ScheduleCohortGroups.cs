using NhsWales.Scheduling.Domain.Types.Ids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhsWales.Scheduling.Domain.Bridges;
public class ScheduleTargetDiseases
{
    public required Guid ScheduleId { get; set; }
    public required TargetDiseaseId TargetDiseaseId { get; set; }
    public Schedule? Schedule { get; set; }
}
