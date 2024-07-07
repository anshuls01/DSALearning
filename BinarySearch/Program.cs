// See https://aka.ms/new-console-template for more information

using BinarySearch;

Console.WriteLine("Binary Search");
// FindCeilingNumber ceilingNumber = new FindCeilingNumber();
// Console.WriteLine(ceilingNumber.Solution(new int[]{2,3,5,9,14,16,18}, 15));

FindMinElementInRotatedSortedArray findMinElementInRotatedSortedArray = new FindMinElementInRotatedSortedArray();
Console.WriteLine(findMinElementInRotatedSortedArray.findMin(new int[]{2,3,5,9,14,16,18}));
Console.WriteLine(findMinElementInRotatedSortedArray.findMin(new int[]{5,9,14,16,18,2,3}));
Console.WriteLine(findMinElementInRotatedSortedArray.findMin(new int[]{5,9,14,16,2,2,3}));
