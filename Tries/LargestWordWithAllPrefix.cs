using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    internal class LargestWordWithAllPrefix
    {
        private readonly TriesOperations operations;
        public LargestWordWithAllPrefix()
        {
             operations = new TriesOperations(); 
        }
        public string CompleteString(int length, string[] words)
        {
            foreach (string word in words)
            {
                operations.InsertWord(word);
            }

            string longestWord = string.Empty;
            foreach (string word in words)
            {
                if (operations.AllPrefixExists(word))
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                    else if (word.Length == longestWord.Length && word.CompareTo(longestWord) < 0)
                    { 
                        longestWord = word;
                    }
                    // checking lexiography bigger number
                    // word.CompareTo(longestWord) < 0
                }
            }
            return longestWord;
        }

        public class TriesOperations

        { 
            private readonly Tries tries;
            public TriesOperations()
            {
                tries = new Tries();
            }

            public bool AllPrefixExists(string word)
            {
                Tries node = tries;
                foreach (char c in word)
                {
                    if (!node.CharExists(c))
                    {
                        return false;
                    }
                    node = node.GetNodeAtChar(c);
                    if (!node.WordCompletedStatus())
                    {
                        return false;
                    }
                }
                return true;// node.WordCompletedStatus();// true;
            }

            public bool wordExist(string word)
            {
                Tries node = tries;
                foreach (char c in word)
                {
                    if (!node.CharExists(c))
                    { 
                        return false;
                    }
                    node = node.GetNodeAtChar(c);
                }
                return node.WordCompletedStatus();// true;
            }
            public void InsertWord(string word)
            {
                Tries node = tries;
                foreach (char c in word)
                {
                    if (!node.CharExists(c))
                    {
                        node.InsertChar(c, new Tries());
                    }
                    node = node.GetNodeAtChar(c);
                }
                node.MarkWordComplete();
            }
        }

        public class Tries
        {
            private Tries[] nodes;
            private bool wordCompleted;
            public Tries()
            {
                nodes = new Tries[26];
                wordCompleted = false;
            }

            public bool CharExists(char c)
            {
                return nodes[c - 'a'] != null;
            }
            public void InsertChar(char c, Tries node)
            {
                nodes[c - 'a'] = node;
            }

            public Tries GetNodeAtChar(char c)
            {
                return nodes[c - 'a'];
            }
            public void MarkWordComplete()
            {
                wordCompleted = true;
            }
            public bool WordCompletedStatus()
            {
                return wordCompleted;
            }
        }
    }
}
