// See https://aka.ms/new-console-template for more information

using HashMap;

Console.WriteLine("Hash Map");
//LongestPalindrome longestPalindrome = new LongestPalindrome();
//Console.WriteLine(longestPalindrome.find("applepie"));

Console.WriteLine("Group Anagrams");
GroupAnagrams groupAnagrams = new GroupAnagrams();
groupAnagrams.Solve(new List<string>() { "eat", "tea", "tan", "ate", "nat", "bat" });
