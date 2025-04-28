using NhsWales.Scheduling.Domain.Abstractions;
using NhsWales.Vaccination.Domain.Interfaces;
using NhsWales.Vaccination.Domain.Types.Id;

namespace NhsWales.Scheduling.Domain.Appointing;
public class AppointmentResponseStatus : BaseLookup<AppointmentResponseStatusId>
{
    public virtual ICollection<AppointmentResponse>? AppointmentResponse { get; set; }
}
