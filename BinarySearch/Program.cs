// See https://aka.ms/new-console-template for more information

using BinarySearch;

Console.WriteLine("Binary Search");
// FindCeilingNumber ceilingNumber = new FindCeilingNumber();
// Console.WriteLine(ceilingNumber.Solution(new int[]{2,3,5,9,14,16,18}, 15));
// Console.WriteLine(ceilingNumber.Solution(new int[]{1,2,3,4,8,10,10,12,19}, 5));
// Console.WriteLine(ceilingNumber.Solution(new int[]{1,2,3,4,5,10,10,12,19}, 5));

// FindMinElementInRotatedSortedArray findMinElementInRotatedSortedArray = new FindMinElementInRotatedSortedArray();
// Console.WriteLine(findMinElementInRotatedSortedArray.findMin(new int[]{2,3,5,9,14,16,18}));
// Console.WriteLine(findMinElementInRotatedSortedArray.findMin(new int[]{5,9,14,16,18,2,3}));
// Console.WriteLine(findMinElementInRotatedSortedArray.findMin(new int[]{5,9,14,16,2,2,3}));

// NoOfTimeArrayRotated noOfTimeArrayRotated = new NoOfTimeArrayRotated();
// Console.WriteLine(noOfTimeArrayRotated.findMinIndex(new int[]{2,3,5,9,14,16,18}));
// Console.WriteLine(noOfTimeArrayRotated.findMinIndex(new int[]{5,9,14,16,18,2,3}));
// Console.WriteLine(noOfTimeArrayRotated.findMinIndex(new int[]{5,9,14,16,2,2,3}));

findElementInSortedRotatedArray findMinElementInRotatedSortedArray = new findElementInSortedRotatedArray();
Console.WriteLine(findMinElementInRotatedSortedArray.find(new int[] { 2, 3, 5, 9, 14, 16, 18 }, 5));
Console.WriteLine(findMinElementInRotatedSortedArray.find(new int[] { 5, 9, 14, 16, 18, 2, 3 }, 5));
Console.WriteLine(findMinElementInRotatedSortedArray.find(new int[] { 3, 5, 9, 14, 16, 19, 2 }, 5));
Console.WriteLine(findMinElementInRotatedSortedArray.find(new int[] { 11, 12, 15, 18, 2, 5, 6, 8 }, 15));

// FindElementInNearlySortedArray findElementInNearlySortedArray = new FindElementInNearlySortedArray();
// Console.WriteLine(findElementInNearlySortedArray.find(new int[]{5, 10, 30, 20, 40},10));
// Console.WriteLine(findElementInNearlySortedArray.find(new int[]{5, 10, 30, 20, 40},20));
// Console.WriteLine(findElementInNearlySortedArray.find(new int[]{5, 10, 30, 20, 40},30));
//
// FirntFirstOneInBinarySortedInfiniteArray firstOneInBinarySortedInfiniteArray = new FirntFirstOneInBinarySortedInfiniteArray();
// Console.WriteLine(firstOneInBinarySortedInfiniteArray.find(new int[] {0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1}));
// Console.WriteLine(firstOneInBinarySortedInfiniteArray.find(new int[] {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
// Console.WriteLine(firstOneInBinarySortedInfiniteArray.find(new int[] {0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 }));
// Console.WriteLine(firstOneInBinarySortedInfiniteArray.find(new int[] {0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1}));
// Console.WriteLine(firstOneInBinarySortedInfiniteArray.find(new int[] {0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}));
// Console.WriteLine(firstOneInBinarySortedInfiniteArray.find(new int[] {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}));
// Console.WriteLine(firstOneInBinarySortedInfiniteArray.find(new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}));

//FindNumberRange numberRange = new FindNumberRange();
//numberRange.findRange(new int[]{1,1,1},1);

FindElementInRotatedSortedArray findElementInRotatedSortedArray = new FindElementInRotatedSortedArray();
Console.WriteLine(findElementInRotatedSortedArray.find(new int[] { 2, 3, 5, 9, 14, 16, 18 }, 5));
Console.WriteLine(findElementInRotatedSortedArray.find(new int[] { 5, 9, 14, 16, 18, 2, 3 }, 5));
Console.WriteLine(findElementInRotatedSortedArray.find(new int[] { 3, 5, 9, 14, 16, 19, 2 }, 5));
Console.WriteLine(findElementInRotatedSortedArray.find(new int[] { 11, 12, 15, 18, 2, 5, 6, 8 }, 15));
