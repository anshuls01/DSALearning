// See https://aka.ms/new-console-template for more information
using DP;
using DP.Knapsack0_1;
using System.Linq.Expressions;
using System.Net.Http.Headers;

Console.WriteLine("Dynamic Programing");
//BestSum bestSum = new BestSum();

//Console.WriteLine(string.Join(",",bestSum.find(7,new int[] { 2,3,4,7}, new Dictionary<int, List<int>>())));
//Console.WriteLine(string.Join(",", bestSum.find(8, new int[] { 2, 3, 5 }, new Dictionary<int, List<int>>())));
//Console.WriteLine(string.Join(",", bestSum.find(8, new int[] { 1, 4, 5 }, new Dictionary<int, List<int>>())));
//Console.WriteLine(string.Join(",", bestSum.find(100, new int[] { 1, 2, 5, 25 }, new Dictionary<int, List<int>>())));


//AllSum allSum = new AllSum();

//List<List<int>> results = allSum.find(7, new int[] { 2, 3, 4, 7 }, new Dictionary<int, List<List<int>>>());
//foreach (List<int> result in results)
//{ 
//    Console.WriteLine(string.Join(",", result));
//}
//results = allSum.find(8, new int[] { 2, 3, 5 }, new Dictionary<int, List<List<int>>>());
//foreach (List<int> result in results)
//{
//    Console.WriteLine(string.Join(",", result));
//}
//results = allSum.find(8, new int[] { 1,4,5 }, new Dictionary<int, List<List<int>>>());
//foreach (List<int> result in results)
//{
//    Console.WriteLine(string.Join(",", result));
//}
//// don't run the below example program will hang
////Console.WriteLine(string.Join(",", allSum.find(100, new int[] { 1, 2, 5, 25 }, new Dictionary<int, List<int>>())));
////results = allSum.find(100, new int[] { 1, 2, 5, 25 }, new Dictionary<int, List<List<int>>>());
////foreach (List<int> result in results)
////{
////    Console.WriteLine(string.Join(",", result));
////}

//CountConstruct countConstruct = new CountConstruct();
//Console.WriteLine(countConstruct.find("abc", new string[] { "a", "bc", "abc" }, new Dictionary<string, int>()));

//AllConstruct allConstruct = new AllConstruct();
////List<List<string>> ways = allConstruct.find("abc", new string[] { "a", "bc", "abc" }, new Dictionary<string, List<List<string>>>());
//List<List<string>> ways = allConstruct.find("purple", new string[] { "purp", "p", "ur","le","purpl" }, new Dictionary<string, List<List<string>>>());

//foreach (var way in ways)
//{
//    Console.WriteLine(string.Join(",", way));
//}

//FurthestBuildingTravel furthestBuildingTravel = new FurthestBuildingTravel();
//Console.WriteLine(furthestBuildingTravel.find(new int[] { 4, 12, 2, 7, 3, 18, 20, 3, 19 }, 10, 2));

//SubSetSum subSetSum = new SubSetSum();
//Console.WriteLine(subSetSum.find_recurssion(new int[] { 2, 3, 7, 8, 10 }, 11));
//Console.WriteLine(subSetSum.find_recurssion_memo(new int[] { 2, 3, 7, 8, 10 }, 11, new Dictionary<string, bool>()));
//Console.WriteLine(subSetSum.find_Tabulation(new int[] { 2, 3, 7, 8, 10 }, 11));

//PartitionEqualSubSetSum partitionEqualSubSetSum = new PartitionEqualSubSetSum();
//Console.WriteLine(partitionEqualSubSetSum.CanPartition(new int[] { 1, 2, 3, 5 }));
//Console.WriteLine(partitionEqualSubSetSum.CanPartition(new int[] { 1,5,11,5 }));

//SubsetSumCountToTargetSum subsetSumCountToTargetSum = new SubsetSumCountToTargetSum();
//Console.WriteLine(subsetSumCountToTargetSum.Count(new int[] { 2, 3, 5, 6, 8, 10 }, 10));
//Console.WriteLine(subsetSumCountToTargetSum.Count_tabulation(new int[] { 2, 3, 5, 6, 8, 10 }, 10));

MaxProfit maxProfit = new MaxProfit();
Console.WriteLine(maxProfit.find(new int[] { 1, 6, 10, 16 }, new int[] { 1, 2, 3, 5 }, 7));
Console.WriteLine(maxProfit.find_memo(new int[] { 1, 6, 10, 16 }, new int[] { 1, 2, 3, 5 }, 7, new Dictionary<string,int>()));
Console.WriteLine(maxProfit.find_BottomUP(new int[] { 1, 6, 10, 16 }, new int[] { 1, 2, 3, 5 }, 7));
Console.WriteLine(maxProfit.find_BottomUP_Space_C(new int[] { 1, 6, 10, 16 }, new int[] { 1, 2, 3, 5 }, 7));
Console.WriteLine(maxProfit.find_BottomUP_Space_C_Reverse(new int[] { 1, 6, 10, 16 }, new int[] { 1, 2, 3, 5 }, 7));

