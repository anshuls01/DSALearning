// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;
using KElementPattern;

Console.WriteLine("Top K Element, Smallest K, largest K element etc...");
Console.WriteLine(
    "Any problem that asks us to find the top/smallest/frequent ‘K’ elements among a given set falls under this pattern.");
Console.WriteLine(
    "The best data structure that comes to mind to keep track of ‘K’ elements is Heap. This pattern will make use of the Heap to solve multiple problems dealing with ‘K’ elements at a time from a set of given elements.");
    
// KLagestNumber kLagestNumber = new KLagestNumber();
// Console.WriteLine(string.Join(",",kLagestNumber.find(new int[]{3,1,5,12,2,11},3)));
// Console.WriteLine(string.Join(",",kLagestNumber.find(new int[]{5, 12, 11, -1, 12 },3)));

// KthSmallestNumber kthSmallestNumber = new KthSmallestNumber();
// Console.WriteLine(kthSmallestNumber.find(new int[]{1, 5, 12, 2, 11, 5},3));
// Console.WriteLine(kthSmallestNumber.find(new int[]{1, 5, 12, 2, 11, 5},4));
// Console.WriteLine(kthSmallestNumber.find(new int[]{5, 12, 11, -1, 12},3));

// ConnectRopes ropes = new ConnectRopes();
// Console.WriteLine(ropes.cost(new int[]{1,3,11,5}));
// Console.WriteLine(ropes.cost(new int[]{3,4,5,6}));
// Console.WriteLine(ropes.cost(new int[]{1,3,11,5,2}));

// TopKFrequentNumbers frequentNumbers = new TopKFrequentNumbers();
// Console.WriteLine(string.Join(",",frequentNumbers.find(new int[]{1,3,5,12,11,12,11},2)));
// Console.WriteLine(string.Join(",",frequentNumbers.find(new int[]{5,12,11,3,11},2)));

FrequencySort frequencySort = new FrequencySort();
Console.WriteLine(frequencySort.Solution("Programming"));
Console.WriteLine(frequencySort.Solution("abcbab"));
