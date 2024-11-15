using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    internal class DistinctSubStrings
    {
        private readonly TrieOperations trieOperations;
        public DistinctSubStrings()
        {
            trieOperations = new TrieOperations();
        }
        public int find(string s)
        {
            return trieOperations.InsertWord(s)+1;
        }

        public class TrieOperations
        {
            private readonly Trie trie;
            public TrieOperations()
            {
                trie = new Trie();
            }

            public int InsertWord(string word)
            {
                int count = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    Trie node = trie;
                    for (int j = i; j < word.Length; j++)
                    {
                        if (!node.Exists(word[j]))
                        {
                            node.Insert(word[j], new Trie());
                            count++;
                        }
                        node = node.GetTriesAtChar(word[j]);
                    }
                }
                return count;
            }
        }

        public class Trie
        {
            public Trie[] node;
            public Trie()
            {
                node = new Trie[26];
            }

            public void Insert(char c, Trie newNode)
            {
                node[c - 'a'] = newNode;
            }

            public bool Exists(char c)
            {
                return node[c - 'a'] != null;
            }

            public Trie GetTriesAtChar(char c)
            {
                return node[c - 'a'];
            }

        }
    }
}
