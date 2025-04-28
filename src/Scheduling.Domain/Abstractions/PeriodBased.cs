using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhsWales.Scheduling.Domain.Abstractions
{
    public abstract class PeriodBased
    {
        public PeriodBased()
        {
            PeriodStart = DateTime.UtcNow.Date;
            PeriodEnd = null;
        }
        public DateTime? PeriodStart { get; set; }

        public DateTime? PeriodEnd { get; set; }

        public bool IsActive => PeriodEnd == null;

        public void DeprecateEntry()
        {
            if (PeriodEnd == null)
            {
                PeriodEnd = DateTime.Now;
            }
        }
    }
}
