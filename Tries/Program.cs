// See https://aka.ms/new-console-template for more information

using Tries;

Console.WriteLine("Tries");
CountWordsStartWithPrefix countWordsStartWithPrefix = new CountWordsStartWithPrefix();
countWordsStartWithPrefix.PrefixAndWordCount(new string[]{"samsung","samsung","vivo"},"vi","samsung","vivo");