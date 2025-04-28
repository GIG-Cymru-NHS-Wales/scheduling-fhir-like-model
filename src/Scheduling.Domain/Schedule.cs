using NhsWales.CommunityCommon.Domain.Types;
using NhsWales.Scheduling.Domain.Bridges;
using NhsWales.Scheduling.Domain.Types.Ids;
using NhsWales.Scheduling.Domain.Types.Types;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain;
public class Schedule
{
    public Guid? Id { get; set; }
    public required bool Active { get; set; }
    public required ServiceTypeId ServiceTypeId { get; set; }
    public required string Name { get; set; }
    public required LocationId LocationId { get; set; }
    public required SystemUriId LocationUri { get; set; }
    public required Period PlanningHorizon { get; set; }
    public string? Notes { get; set; }
    public required ConcurrencyToken ConcurrencyToken { get; set; }
    public required WeeklyTemplate WeeklyTemplate { get; set; }
    public required AppointingMethodId AppointingMethodId { get; set; }
    public required TimeOnly StartTime { get; set; }
    public required TimeOnly EndTime { get; set; }
    public required SessionAudienceId SessionAudienceId { get; set; }
    public int? LengthOfEachAppointmentMinutes { get; set; }
    public int? NumberOfAppointmentsPerTimeslot { get; set; }
    public int? MaximumNumberOfAppointments { get; set; }
    public required TimeOnly BreakStart { get; set; }
    public required TimeOnly BreakEnd { get; set; }
    public required bool ExcludePublicHolidays { get; set; }
    public required BookingFlags BookingFlags { get; set; }
    public required DateOfBirthRangeCriteria DateOfBirthCriteria { get; set; }
    public required AgeCriteria AgeCriteria { get; set; }
    public required SchoolYearFlags SchoolYearFlags { get; set; }
    public required FrequencyPatternId FrequencyPatternId { get; set; }

    public virtual ICollection<Timeslot>? Timeslots { get; set; }
    public virtual ServiceType? ServiceType { get; set; }
    public virtual AppointingMethod? AppointingMethod { get; set; }
    public virtual SessionAudience? SessionAudience { get; set; }
    public virtual FrequencyPattern? FrequencyPattern { get; set; }
    public virtual ICollection<ScheduleTargetDiseases>? ScheduleTargetDiseases { get; set; }
    public virtual ICollection<ScheduleCohortGroups>? ScheduleCohortGroups { get; set; }

}
