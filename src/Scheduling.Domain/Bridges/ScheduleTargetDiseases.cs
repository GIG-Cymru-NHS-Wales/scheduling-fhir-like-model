namespace NhsWales.Scheduling.Domain.Bridges;
public class ScheduleCohortGroups
{
    public required Guid ScheduleId { get; set; }
    public required Guid CohortGroupId { get; set; }
    public Schedule? Schedule { get; set; }
}
