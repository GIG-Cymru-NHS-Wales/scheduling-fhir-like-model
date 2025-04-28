using NhsWales.CommunityCommon.Domain;
using NhsWales.CommunityCommon.Domain.Types;
using NhsWales.CommunityCommon.Domain.Types.Patient;
using NhsWales.Scheduling.Domain.Abstractions;
using NhsWales.Scheduling.Domain.Types.Enums;
using NhsWales.Scheduling.Domain.Types.Ids;
using NhsWales.Scheduling.Domain.Types.Types;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhsWales.Scheduling.Domain;
public partial class Consent : PeriodBased
{

    public Consent()
    {
    }

    public Consent(NhsNumber subject, string targetDiseaseId, ConsentStatusId consentStatusId, ConsentCategoryId consentCategoryId, string grantor, string manager, string decision)
    {
        Subject = subject;
        TargetDiseaseId = targetDiseaseId;
        ConsentStatusId = consentStatusId;
        ConsentCategoryId = consentCategoryId;
        Grantor = grantor;
        Manager = manager;
        Decision = decision;
        ConcurrencyToken = new ConcurrencyToken(DateTime.Now);
    }

    public Guid? Id { get; set; }
    public NhsNumber Subject { get; set; } = "1111111111";
    public string TargetDiseaseId { get; set; } = "Coronavirus";
    public ConsentStatusId ConsentStatusId { get; set; } = "ancd";
    public ConsentCategoryId ConsentCategoryId { get; set; } = "ancd";
    public string Grantor { get; set; } = "ancd";
    public string Manager { get; set; } = "ancd";
    public string Decision { get; set; } = "ancd";

    public ConcurrencyToken ConcurrencyToken { get; set; } = new ConcurrencyToken();
    public virtual ConsentStatus? ConsentStatus { get; set; }
    public virtual ConsentCategory? ConsentCategory { get; set; }

    [NotMapped]
    public IReadOnlyCollection<DomainEvent> DomainEvents => throw new NotImplementedException();

    public void ClearDomainEvents()
    {
        throw new NotImplementedException();
    }
}


  
