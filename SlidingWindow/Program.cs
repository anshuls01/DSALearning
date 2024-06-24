// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using SlidingWindow;

Console.WriteLine("Sliding Window");
// MaxSumSubArrayOfSizeK maxSumSubArrayOfSizeK = new MaxSumSubArrayOfSizeK();
// Console.WriteLine(maxSumSubArrayOfSizeK.Solution(new int[]{2,5,1,8,2,9,1}, 3));

// FirstNegativeEveryWindowOfSizeK firstNegativeEveryWindowOfSizeK = new FirstNegativeEveryWindowOfSizeK();
// Console.WriteLine(string.Join(",",firstNegativeEveryWindowOfSizeK.Solution(new int[]{12,-1,-7,8,-15,30,16,28},3)));

// CountOccurenceOfAnagrams countOccurenceOfAnagrams = new CountOccurenceOfAnagrams();
// Console.WriteLine(countOccurenceOfAnagrams.Solution("aabaabaa", "aaba"));

MaximumOfAllSubArrayOfSizeK maximumOfAllSubArrayOfSizeK = new MaximumOfAllSubArrayOfSizeK();
Console.WriteLine(string.Join(",", maximumOfAllSubArrayOfSizeK.Solution(new int[]{1,3,-1,-3,5,3,6,7},3)));
Console.WriteLine(string.Join(",", maximumOfAllSubArrayOfSizeK.Solution2(new int[]{1,3,-1,-3,5,3,6,7},3)));


