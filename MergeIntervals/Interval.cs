namespace MergeIntervals;

public class Interval
{
    public int start { get; set; }
    public int end { get; set; }

    public Interval(int start, int end)
    {
        this.start = start;
        this.end = end;
    }
}