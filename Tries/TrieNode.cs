using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    public class TrieNode
    {
        public TrieNode[] trieNode;
        private bool wordCompleteFlag;
        private int startsWith;
        private int endsWith;
        public TrieNode()
        {
            trieNode = new TrieNode[128]; // ascii char range
            wordCompleteFlag = false;
            startsWith = 0;
            endsWith = 0;
        }

        public bool CharExist(char c)
        {
            return trieNode[c] != null;
        }

        public void InsertChar(char c, TrieNode node)
        {
            trieNode[c] = node;
            startsWith++;
        }

        public TrieNode GetNodeAtChar(char c)
        {
            return trieNode[c];
        }

        public void SetWordComplete()
        {
            wordCompleteFlag = true;
            startsWith++;
            endsWith++;
        }

        public int PrefixCount()
        {
            return startsWith;
        }
        public int WordCompletedCount()
        {
            return endsWith;
        }
        public bool WordCompleted() { 
            return wordCompleteFlag;
        }
        public void RemoveChar()
        {
            startsWith--;
            if (wordCompleteFlag == true)
            {
                endsWith--;
                wordCompleteFlag = false;
            }
        }
    }
}
