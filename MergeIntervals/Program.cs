// See https://aka.ms/new-console-template for more information

using MergeIntervals;

Console.WriteLine("Merge Intervals");
// Console.WriteLine("Merge all overlapping intervals");
// Merge merge = new Merge();
// List<Interval> mergedInterval = merge.MergeIntervals(new List<Interval>()
// {
//     new Interval(1,4),
//     new Interval(2,5),
//     new Interval(7,9),
// });
// foreach (Interval interval in mergedInterval)
// {
//     Console.WriteLine($"{interval.start},{interval.end}");
// }
// InsertInterval insertInterval = new InsertInterval();
// List<Interval> intervals  = insertInterval.Solution(new List<Interval>()
// {
//     new Interval(1,3),
//     new Interval(5,7),
//     new Interval(8,12)
// }, new Interval(4,6));
//
// foreach (Interval interval in intervals)
// {
//     Console.WriteLine($"{interval.start},{interval.end}");
// }
//
// Console.WriteLine("-----");
//
// intervals  = insertInterval.Solution(new List<Interval>()
// {
//     new Interval(1,3),
//     new Interval(5,7),
//     new Interval(8,12)
// }, new Interval(4,10));
//
// foreach (Interval interval in intervals)
// {
//     Console.WriteLine($"{interval.start},{interval.end}");
// }
// Console.WriteLine("-----");
// intervals  = insertInterval.Solution(new List<Interval>()
// {
//     new Interval(2,3),
//     new Interval(5,7),
//     }, new Interval(1,4));
//
// foreach (Interval interval in intervals)
// {
//     Console.WriteLine($"{interval.start},{interval.end}");
// }

IntervalsIntersection intervalsIntersection = new IntervalsIntersection();
List<Interval> intervals  = intervalsIntersection.getList(new List<Interval>()
{
    new Interval(1,3),
    new Interval(5,6),
    new Interval(7,9)
}, new List<Interval>()
{
    new Interval(2,3),
    new Interval(5,7)
});

foreach (Interval interval in intervals)
{
    Console.WriteLine($"{interval.start},{interval.end}");
}

Console.WriteLine("-------");
intervals  = intervalsIntersection.getList(new List<Interval>()
{
    new Interval(1,3),
    new Interval(5,7),
    new Interval(9,12)
}, new List<Interval>()
{
    new Interval(5,10)
});

foreach (Interval interval in intervals)
{
    Console.WriteLine($"{interval.start},{interval.end}");
}