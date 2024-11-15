// See https://aka.ms/new-console-template for more information

using Tries;

Console.WriteLine("Tries");
//CountWordsStartWithPrefix countWordsStartWithPrefix = new CountWordsStartWithPrefix();
//countWordsStartWithPrefix.PrefixAndWordCount(new string[] { "samsung", "samsung", "vivo" }, "vi", "samsung", "vivo");

//CountPrefixAndCompletedWord countPrefixAndCompletedWord  = new CountPrefixAndCompletedWord();
//countPrefixAndCompletedWord.print(new string[] { "samsung", "samsung", "vivo" }, "vi", "samsung", "vivo");

//LargestWordWithAllPrefix largestWordWithAllPrefix = new LargestWordWithAllPrefix();
//Console.WriteLine(largestWordWithAllPrefix.CompleteString(6, new string[] { "n", "ni", "nin", "ninj", "ninja", "ninga" }));
//Console.WriteLine(largestWordWithAllPrefix.CompleteString(2, new string[] { "ab", "bc"}));

DistinctSubStrings distinctSubStrings = new DistinctSubStrings();
Console.WriteLine(distinctSubStrings.find("abab"));