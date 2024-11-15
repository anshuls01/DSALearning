using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    internal class CountPrefixAndCompletedWord
    {
        private readonly TrieCurd1 trieCurd1;
        public CountPrefixAndCompletedWord()
        {
            trieCurd1 = new TrieCurd1();
        }
        public void print(string[] words, string prefix, string word, string wordToErase)
        {
            foreach (string w in words)
            {
                trieCurd1.InsertWord(w);
            }
            Console.WriteLine("#############################");
            Console.WriteLine($"Prefix Exist: {prefix}: {trieCurd1.isWordStartsWith(prefix)}");
            Console.WriteLine($"Prefix Count: {trieCurd1.PrefixCount(prefix)}");

            Console.WriteLine($"Word Exist: {word}: {trieCurd1.isWordExist(word)}");
            Console.WriteLine($"Completed Word Count: {trieCurd1.CountOfExistingWord(word)}");

            trieCurd1.RemoveWord(wordToErase);

            Console.WriteLine($"Prefix Exist: {prefix}: {trieCurd1.isWordStartsWith(prefix)}");
            Console.WriteLine($"Prefix Count: {trieCurd1.PrefixCount(prefix)}");

            Console.WriteLine($"Word Exist: {word}: {trieCurd1.isWordExist(word)}");
            Console.WriteLine($"Completed Word Count: {trieCurd1.CountOfExistingWord(word)}");
            Console.WriteLine("#############################");
        }
    }
}
