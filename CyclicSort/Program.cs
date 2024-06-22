// See https://aka.ms/new-console-template for more information

using CyclicSort;

Console.WriteLine("Cyclic Sort");
SortArray sortArray = new SortArray();
Console.WriteLine(string.Join(",", sortArray.Solution(5, new int[]{3,5,2,1,4}) ?? Array.Empty<int>()));