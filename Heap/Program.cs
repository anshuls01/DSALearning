// See https://aka.ms/new-console-template for more information

using Heap;

Console.WriteLine("Heap");
Console.WriteLine("Heap implemented using the priority queue");

KthLargestElement kthLargestElement = new KthLargestElement();
Console.WriteLine(kthLargestElement.find(new int[]{7,10,4,3,20,15}, 3));

KthSmallestElement kthSmallestElement = new KthSmallestElement();
Console.WriteLine(kthSmallestElement.find(new int[]{7,10,4,3,20,15},3));

KLargerElement kLargerElement = new KLargerElement();
Console.WriteLine(string.Join(",",kLargerElement.find(new int[]{7,10,4,3,20,15}, 3)));
Console.WriteLine(string.Join(",",kLargerElement.find1(new int[]{7,10,4,3,20,15}, 3)));
Console.WriteLine(string.Join(",",kLargerElement.find(new int[]{7,10,4,3,20,15,17}, 1)));
Console.WriteLine(string.Join(",",kLargerElement.find1(new int[]{7,10,4,3,20,15,17}, 1)));
