// See https://aka.ms/new-console-template for more information

using CyclicSort;

Console.WriteLine("Cyclic Sort");
// SortArray sortArray = new SortArray();
// Console.WriteLine(string.Join(",", sortArray.Solution(5, new int[]{3,5,2,1,4}) ?? Array.Empty<int>()));

// FindMissingNumber findMissingNumber = new FindMissingNumber();
// Console.WriteLine( findMissingNumber.solution( new int[]{3,0,1})) ;
// Console.WriteLine( findMissingNumber.Solution2( new int[]{3,0,1})) ;

// FindAllDiaspearedNumberInAArray findAllDiaspearedNumberInAArray = new FindAllDiaspearedNumberInAArray();
// Console.WriteLine(string.Join(",", findAllDiaspearedNumberInAArray.Solution(new int[]{4,3,2,7,8,2,3,1})));

// FindFirstPositiveMissingNumber firstPositiveMissingNumber = new FindFirstPositiveMissingNumber();
// Console.WriteLine(firstPositiveMissingNumber.Solution(new int[]{3,4,-1,1})??-1);

FindFirstKMissingNumber firstKMissingNumber = new FindFirstKMissingNumber();
Console.WriteLine(string.Join(",",firstKMissingNumber.findNumbers(new int[]{2, 3, 4},3)));