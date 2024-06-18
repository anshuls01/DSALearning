namespace MergeIntervals;

public class IntervalsIntersection
{
    public List<Interval> getList(List<Interval> first, List<Interval> second)
    {
        if (first.Count == 0 || second.Count == 0)
        {
            return new List<Interval>();
        }

        List<Interval> result = new List<Interval>();
        int count1 = 0;
        int count2 = 0;
        while (count1 < first.Count && count2 < second.Count)
        {
            Interval firstInterval = first[count1];
            Interval secondInterval = second[count2];

            if (firstInterval.end < secondInterval.start)
            {
                count1++;
            }
            else if ((firstInterval.start <= secondInterval.start && firstInterval.end >= secondInterval.start) 
                     || (secondInterval.start<=firstInterval.start && secondInterval.end>=firstInterval.start))
            {
                firstInterval.start = Math.Max(firstInterval.start, secondInterval.start);
                firstInterval.end = Math.Min(firstInterval.end, secondInterval.end);
                result.Add(firstInterval);

                if (firstInterval.end < secondInterval.end)
                {
                    count1++;
                }
                else if (firstInterval.end > secondInterval.end)
                {
                    count2++;
                }
                else
                {
                    count1++;
                    count2++;
                }
            }
            // else if( secondInterval.start<=firstInterval.start && secondInterval.end>=firstInterval.start )
            // {
            //     firstInterval.start = Math.Max(firstInterval.start, secondInterval.start);
            //     firstInterval.end = Math.Min(firstInterval.end, secondInterval.end);
            //     result.Add(firstInterval);
            //     if (firstInterval.end < secondInterval.end)
            //     {
            //         count1++;
            //     }
            //     else if (firstInterval.end > secondInterval.end)
            //     {
            //         count2++;
            //     }
            //     else
            //     {
            //         count1++;
            //         count2++;
            //     }
            // }
        }

        return result;
    }

}