// See https://aka.ms/new-console-template for more information

using TwoPointers;

Console.WriteLine("Two pointers");

// Console.WriteLine("Find Pair for target sum, in a sorted array");
// PairWithTargetSum pairWithTargetSum = new PairWithTargetSum();
// Console.WriteLine(string.Join(",",pairWithTargetSum.findPair(new int[]{1,2,3,4,6}, 6) ?? Array.Empty<int>()));
// Console.WriteLine(string.Join(",",pairWithTargetSum.findPair(new int[]{2,5,9,11}, 11) ?? Array.Empty<int>()));


// Console.WriteLine("Find non duplicate number and move all non duplicate instances at the beginning of the array ");
// FindNonDuplicateNumber findNonDuplicateNumber = new FindNonDuplicateNumber();
// Console.WriteLine(findNonDuplicateNumber.MoveNumbers(new int[]{2,3,3,3,6,9,9}));
// Console.WriteLine(findNonDuplicateNumber.MoveNumbers(new int[]{2,2,2,11}));

// Console.WriteLine("Remove all key element from a unsorted array and return the length of the final array");
// RemoveAllKeyInstance removeAllKeyInstance = new RemoveAllKeyInstance();
// Console.WriteLine(removeAllKeyInstance.GetNonDuplicateArrayLength(new int[]{3,2,3,6,3,10,9,3},3));
// Console.WriteLine(removeAllKeyInstance.GetNonDuplicateArrayLength(new int[]{2,11,2,2,1},2));

// Console.WriteLine("Squaring a sorted array");
// SquaringASortedArray squaringASortedArray = new SquaringASortedArray();
// Console.WriteLine(string.Join(",",squaringASortedArray.solution(new int[]{-2,-1,0,2,3})??Array.Empty<int>()));
// Console.WriteLine(string.Join(",",squaringASortedArray.solution(new int[]{-3,-1,0,1,2})??Array.Empty<int>()));

Console.WriteLine("Triplet sum to zero, without duplicate");
AllUniqueTripletsSumtoZero allUniqueTripletsSumtoZero = new AllUniqueTripletsSumtoZero();
List<int[]>? result;
// result = allUniqueTripletsSumtoZero.find(new int[] { -3, 0, 1, 2, -1, 1, -2 });
// foreach (int[] triplet in result)
// {
//     Console.WriteLine(string.Join(",", triplet));
// }
// Console.WriteLine("-------");
result = allUniqueTripletsSumtoZero.finTriplets(new int[] { -3, 0, 1, 2, -1, 1, -2 });
foreach (int[] triplet in result)
{
    Console.WriteLine(string.Join(",", triplet));
}
// if (result != null)
// {
//     result.Sort();
// }