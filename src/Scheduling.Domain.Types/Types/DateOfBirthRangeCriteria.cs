using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhsWales.Scheduling.Domain.Types.Types;
public class DateOfBirthRangeCriteria
{
    public DateTime? DateOfBirthFrom { get; set; }
    public DateTime? DateOfBirthTo { get; set; }
}
