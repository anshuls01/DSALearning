// See https://aka.ms/new-console-template for more information

using LeetCode75.ArrayStrings;

Console.WriteLine("LeetCode 75");

Console.WriteLine("Arrays/Strings");
//GratestCommonDivisiorOfString gcd = new GratestCommonDivisiorOfString();
//Console.WriteLine(gcd.GcdOfStrings("AAAAAAAAA","AAACCC"));

//ReverseWordsInAString reverseWordsInAString = new ReverseWordsInAString();
//reverseWordsInAString.ReverseWords("the sky is blue");

//BuySellStocks1 buySellStocks1 = new BuySellStocks1();
//buySellStocks1.Solve(new int[] {7,1,5,3,6,4 });
//buySellStocks1.Solve(new int[] { 7,3,4,1,10,6});
//buySellStocks1.Solve(new int[] { 7,2,7,1,5,5});
//buySellStocks1.Solve(new int[] { 10,9});
BestTimeToFlightTickets bestTimeToFlightTickets = new BestTimeToFlightTickets();
bestTimeToFlightTickets.Solve(new int[]{4,3,5,11,2 },new int[]{1,6,10,2,9 });
bestTimeToFlightTickets.Solve(new int[] { 1,2,3,4 }, new int[] { 4,3,2,1 });