// See https://aka.ms/new-console-template for more information

using SlidingWindow;

Console.WriteLine("Sliding Window");
MaxSumSubArrayOfSizeK maxSumSubArrayOfSizeK = new MaxSumSubArrayOfSizeK();
Console.WriteLine(maxSumSubArrayOfSizeK.Solution(new int[]{2,5,1,8,2,9,1}, 3));