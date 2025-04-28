using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhsWales.Scheduling.Domain.Types.Types;
public class BookingFlags
{
    public required bool AllowMassBookings { get; set; }
    public required bool AllowManualBookings { get; set; }
}
