namespace MergeIntervals;

public class Merge
{
    public List<Interval> MergeIntervals(List<Interval> intervals)
    {
        if (intervals.Count < 2)
        {
            return intervals;
        }
        intervals.Sort((a,b)=>a.start.CompareTo(b.start));
        Stack<Interval> stack = new Stack<Interval>();
        foreach (Interval interval in intervals)
        {
            if (stack.Count == 0)
            {
                stack.Push(interval);
            }
            else
            {
                Interval cInterval = stack.Peek();
                if (cInterval.end >= interval.start)
                {
                    cInterval.end = Math.Max(interval.end,cInterval.end);
                }
                else
                {
                    stack.Push(interval);
                }
            }
        }

        return stack.ToList();
    }
    
}