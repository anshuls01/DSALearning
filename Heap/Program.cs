// See https://aka.ms/new-console-template for more information

using System.Runtime.Serialization.Json;
using Heap;

Console.WriteLine("Heap");
Console.WriteLine("Heap implemented using the priority queue");

// KthLargestElement kthLargestElement = new KthLargestElement();
// Console.WriteLine(kthLargestElement.find(new int[]{7,10,4,3,20,15}, 3));
//
// KthSmallestElement kthSmallestElement = new KthSmallestElement();
// Console.WriteLine(kthSmallestElement.find(new int[]{7,10,4,3,20,15},3));
//
// KLargerElement kLargerElement = new KLargerElement();
// Console.WriteLine(string.Join(",",kLargerElement.find(new int[]{7,10,4,3,20,15}, 3)));
// Console.WriteLine(string.Join(",",kLargerElement.find1(new int[]{7,10,4,3,20,15}, 3)));
// Console.WriteLine(string.Join(",",kLargerElement.find(new int[]{7,10,4,3,20,15,17}, 1)));
// Console.WriteLine(string.Join(",",kLargerElement.find1(new int[]{7,10,4,3,20,15,17}, 1)));
//
// SortAkSortedArray sortAkSortedArray = new SortAkSortedArray();
// Console.WriteLine(string.Join(",",sortAkSortedArray.sort(new int[]{6,5,3,2,8,10,9},4)));
//
// KClosestNumber kClosestNumber = new KClosestNumber();
// Console.WriteLine(string.Join(",",kClosestNumber.find(new int[]{6,5,9,8,7}, 3,7)));

TopKFrequentElements topKFrequentElements = new TopKFrequentElements();
Console.WriteLine(string.Join(",",topKFrequentElements.find(new int[]{1,1,1,3,2,2,4}, 2)));
Console.WriteLine(string.Join(",",topKFrequentElements.find(new int[]{1,1,1,3,3,3,3,2,2,2,4, 4}, 3)));

FrequencySort frequencySort = new FrequencySort();
Console.WriteLine(string.Join(",",frequencySort.get(new int[]{1,2,1,1,3,2,4})));

KClosestPointToOrigin closestPointToOrigin = new KClosestPointToOrigin();
List<int[]> pairs = closestPointToOrigin.getClosetPair(new List<int[]>{
                                                                                    new int[]{1,3},
                                                                                    new int[]{-2,2},
                                                                                    new int[]{5,8},
                                                                                    new int[]{0,1},
                                                                                },2);
if (pairs != null && pairs.Count > 0)
{
    foreach (int[] pair in pairs)
    {
        Console.WriteLine(string.Join(",",pair));
    }
}