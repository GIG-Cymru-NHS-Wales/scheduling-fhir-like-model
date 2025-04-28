using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhsWales.Scheduling.Domain.Types.Types;
public class WeeklyTemplate
{
    public required bool Monday { get; set; }
    public required bool Tuesday { get; set; }
    public required bool Wednesday { get; set; }
    public required bool Thursday { get; set; }
    public required bool Friday { get; set; }
    public required bool Saturday { get; set; }
    public required bool Sunday { get; set; }
}
