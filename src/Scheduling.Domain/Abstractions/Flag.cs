using NhsWales.CommunityCommon.Domain.Types;
using NhsWales.CommunityCommon.Domain.Types.Patient;
using NhsWales.Scheduling.Domain.Types.Types;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain.Abstractions;
public abstract class Flag
{
    public required Guid Id { get; set;}
    public required  FlagStatusId FlagStatusId { get; set; }
    public required FlagCategoryId FlagCategoryId { get; set; }
    public required FlagCodeId FlagCodeId { get; set; }
    public required NhsNumber PatientNhsNumber { get; set; }
    public required Period Period { get; set; }
    public Guid? EncounterId { get; set; }
    public string? AuthorId { get; set; }
    public required ConcurrencyToken ConcurrencyToken { get; set; }

}
