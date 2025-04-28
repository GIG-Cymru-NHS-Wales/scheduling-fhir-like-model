namespace NhsWales.Scheduling.Domain.Types.Types;
public class Period
{
    public Period() { }
    public Period(DateTime start, DateTime? end)
    {
        Start = start;
        End = end;
    }

    public DateTime Start { get; set; }
    public DateTime? End { get; set; }
}
