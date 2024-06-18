namespace MergeIntervals;

public class InsertInterval
{
    public List<Interval> Solution(List<Interval> intervals, Interval newInterval)
    {
        if (intervals.Count < 1)
        {
            return new List<Interval>() { newInterval };
        }

        //since already sorted, no need to sort it again
        //intervals.Sort((a, b) => a.start.CompareTo(b.start)); //NLogN and S: O(N)

        // traverse through the array to find right spot to merge

        Stack<Interval> stack = new Stack<Interval>();
        int counter = 0;
        foreach (var t in intervals)
        {
            if (t.end < newInterval.start)
            {
                stack.Push(t);
                counter++;
            }
        }

        if (intervals.Count > counter)
        {
            Interval current = intervals[counter];
            if (newInterval.end < current.start)
            {
                stack.Push(newInterval);
            }
            else //if (newInterval.end >= current.start)
            {
                newInterval.start = Math.Min(newInterval.start, current.start);
                newInterval.end = Math.Max(newInterval.end, current.end);
                stack.Push(newInterval);
                counter++;
            }
            
        }

        for (int i = counter;i<intervals.Count;i++)
        {
            Interval previous = stack.Peek();
            if (previous.end >= intervals[i].start)
            {
                previous.end = Math.Max(intervals[i].end, previous.end);
            }
            else
            {
                stack.Push(intervals[counter]);
            }
        }
        return stack.ToList();
    }

}