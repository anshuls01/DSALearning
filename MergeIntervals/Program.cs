// See https://aka.ms/new-console-template for more information

using MergeIntervals;

Console.WriteLine("Merge Intervals");
Console.WriteLine("Merge all overlapping intervals");
Merge merge = new Merge();
List<Interval> mergedInterval = merge.MergeIntervals(new List<Interval>()
{
    new Interval(1,4),
    new Interval(2,5),
    new Interval(7,9),
});
foreach (Interval interval in mergedInterval)
{
    Console.WriteLine($"{interval.start},{interval.end}");
}