using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Enums;
[JsonConverter(typeof(LookupJsonConverter<string>))]
[TypeConverter(typeof(LookupTypeConverter<string, AppointmentCancellationReasonEnum>))]
public record AppointmentCancellationReasonEnum : Lookup<string>
{
    public AppointmentCancellationReasonEnum(string id, string code, string name)
        : base(id, code, name) { }

    public static readonly AppointmentCancellationReasonEnum Patient = new("pat", "pat", "Patient");
    public static readonly AppointmentCancellationReasonEnum CanceledReminder = new("pat-crs", "pat-crs", "Canceled via automated reminder system");
    public static readonly AppointmentCancellationReasonEnum CanceledPortal = new("pat-cpp", "pat-cpp", "Canceled via Patient Portal");
    public static readonly AppointmentCancellationReasonEnum Deceased = new("pat-dec", "pat-dec", "Deceased");
    public static readonly AppointmentCancellationReasonEnum FeelingBetter = new("pat-fb", "pat-fb", "Feeling Better");
    public static readonly AppointmentCancellationReasonEnum LackTransport = new("pat-lt", "pat-lt", "Lack of Transportation");
    public static readonly AppointmentCancellationReasonEnum NoInsurance = new("pat-mt", "pat-mt", "No longer covered by insurance");
    public static readonly AppointmentCancellationReasonEnum Moved = new("pat-mv", "pat-mv", "Moved Residence");
    public static readonly AppointmentCancellationReasonEnum Pregnant = new("pat-preg", "pat-preg", "Pregnant");
    public static readonly AppointmentCancellationReasonEnum WaitList = new("pat-swl", "pat-swl", "Scheduled from Wait List");
    public static readonly AppointmentCancellationReasonEnum ChangedProvider = new("pat-ucp", "pat-ucp", "Unhappy/Changed Provider");
    public static readonly AppointmentCancellationReasonEnum Provider = new("prov", "prov", "Provider");
    public static readonly AppointmentCancellationReasonEnum Personal = new("prov-pers", "prov-pers", "Personal");
    public static readonly AppointmentCancellationReasonEnum Discharged = new("prov-dch", "prov-dch", "Discharged");
    public static readonly AppointmentCancellationReasonEnum Education = new("prov-edu", "prov-edu", "Edu/Meeting");
    public static readonly AppointmentCancellationReasonEnum Hospitalized = new("prov-hosp", "prov-hosp", "Hospitalized");
    public static readonly AppointmentCancellationReasonEnum LabsOutOfRange = new("prov-labs", "prov-labs", "Labs Out of Acceptable Range");
    public static readonly AppointmentCancellationReasonEnum MRIForm = new("prov-mri", "prov-mri", "MRI Screening Form Marked Do Not Proceed");
    public static readonly AppointmentCancellationReasonEnum OncologyPlanChange = new("prov-onc", "prov-onc", "Oncology Treatment Plan Changes");
    public static readonly AppointmentCancellationReasonEnum Maintenance = new("maint", "maint", "Equipment Maintenance/Repair");
    public static readonly AppointmentCancellationReasonEnum PrepMedIncomplete = new("meds-inc", "meds-inc", "Prep/Med Incomplete");
    public static readonly AppointmentCancellationReasonEnum Other = new("other", "other", "Other");
    public static readonly AppointmentCancellationReasonEnum TherapyCap = new("oth-cms", "oth-cms", "CMS Therapy Cap Service Not Authorized");
    public static readonly AppointmentCancellationReasonEnum Error = new("oth-err", "oth-err", "Error");
    public static readonly AppointmentCancellationReasonEnum Financial = new("oth-fin", "oth-fin", "Financial");
    public static readonly AppointmentCancellationReasonEnum ImproperIV = new("oth-iv", "oth-iv", "Improper IV Access/Infiltrate IV");
    public static readonly AppointmentCancellationReasonEnum NoInterpreter = new("oth-int", "oth-int", "No Interpreter Available");
    public static readonly AppointmentCancellationReasonEnum MedUnavailable = new("oth-mu", "oth-mu", "Prep/Med/Results Unavailable");
    public static readonly AppointmentCancellationReasonEnum RoomMaintenance = new("oth-room", "oth-room", "Room/Resource Maintenance");
    public static readonly AppointmentCancellationReasonEnum OrderError = new("oth-oerr", "oth-oerr", "Schedule Order Error");
    public static readonly AppointmentCancellationReasonEnum WalkInError = new("oth-swie", "oth-swie", "Silent Walk In Error");
    public static readonly AppointmentCancellationReasonEnum Weather = new("oth-weath", "oth-weath", "Weather");
    public static readonly AppointmentCancellationReasonEnum PatientCanceledDirectly = new("pat-cds", "pat-cds", "Patient: Canceled by patient directly");
    public static readonly AppointmentCancellationReasonEnum PatientCanceledViaText = new("pat-ctx", "pat-ctx", "Patient: Canceled via text");
}