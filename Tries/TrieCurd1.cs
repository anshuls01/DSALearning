using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    internal class TrieCurd1
    {
        private readonly TrieNode root;

        public TrieCurd1()
        {
                root = new TrieNode();
        }

        public void InsertWord(string word)
        {
            TrieNode node = root;
            foreach (char c in word)
            {
                if (!node.CharExist(c))
                {
                    node.InsertChar(c, new TrieNode());
                }
                node = node.GetNodeAtChar(c);
            }

            node.SetWordComplete();
        }

        // I'll implement this using the count parameter, else I need to apply recursing [bottom apprach] to remove word
        public void RemoveWord(string word)
        {
            TrieNode node = root;
            foreach (char c in word)
            {
                if (!node.CharExist(c))
                {
                    return;
                }
                node.RemoveChar();
                node = node.GetNodeAtChar(c);
            }
            //node.SetWordComplete();
        }

        public int CountOfExistingWord(string word)
        {
            TrieNode node = root;
            foreach (char c in word)
            {
                if (!node.CharExist(c))
                {
                    return 0;
                }
                node = node.GetNodeAtChar(c);
            }
            if (node.WordCompleted())
            { 
                return node.WordCompletedCount();
            }
            return 0;
        }

        public int PrefixCount(string word)
        { 
            TrieNode node = root;
            foreach (char c in word)
            {
                if (!node.CharExist(c))
                {
                    return 0;
                }
                node = node.GetNodeAtChar(c);   
            }
           return node.PrefixCount();
        }

        public bool isWordExist(string word)
        {
            TrieNode node = root;
            foreach (char c in word) {
                if (!node.CharExist(c))
                {
                    return false;
                }
                node = node.GetNodeAtChar(c);
            }
            return node.WordCompleted();
        }
        public bool isWordStartsWith(string word)
        {
            TrieNode node = root;
            foreach (char c in word)
            {
                if (!node.CharExist(c))
                {
                    return false;
                }
                node = node.GetNodeAtChar(c);
            }
            return node.PrefixCount() > 0;
            //return true;
        }

    }
}
