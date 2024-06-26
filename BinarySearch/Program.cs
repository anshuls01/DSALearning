// See https://aka.ms/new-console-template for more information

using BinarySearch;

Console.WriteLine("Binary Search");
FindCeilingNumber ceilingNumber = new FindCeilingNumber();
Console.WriteLine(ceilingNumber.Solution(new int[]{2,3,5,9,14,16,18}, 15));