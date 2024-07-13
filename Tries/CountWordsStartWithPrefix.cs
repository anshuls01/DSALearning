namespace Tries;

public class CountWordsStartWithPrefix
{
    private readonly Node root;

    public CountWordsStartWithPrefix()
    {
        root = new Node();
    }

    public void PrefixAndWordCount(string[] words, string prefix, string word, string wordToErase)
    {
        if (words == null || words.Length == 0)
        {
            return;
        }

        InsertWords(words);
        GetPrefixAndWordCount(prefix,word);

        EraseWord(wordToErase);
        GetPrefixAndWordCount(prefix,word);
    }
    
    void GetPrefixAndWordCount(string prefix, string word)
    {
        int prefixCount = PrefixSearch(prefix);
        int wordCount = CountWordsEqualTo(word);

        Console.WriteLine("Prefix Count : " + prefixCount);
        Console.WriteLine("Word Count : " + wordCount);
    }

    private void EraseWord(string word)
    {
        Node node = root;
        foreach (char c in word)
        {
            if (!node.IsExist(c))
            {
                return;
            }

            node.ReduceCount();
            node = node.GetNext(c);
        }

        node.ReduceWordCompletedCount();
    }

    private int CountWordsEqualTo(string word)
    {
        Node node = root;
        foreach (char c in word)
        {
            if (!node.IsExist(c))
            {
                return 0;
            }

            node = node.GetNext(c);
        }

        return node.getCompletedWordCount();
    }

    private int PrefixSearch(string prefix)
    {
        Node node = root;
        int count = 0;
        foreach (char c in prefix)
        {
            if (!node.IsExist(c))
            {
                return 0;
            }

            node = node.GetNext(c);
        }

        return node.getCount();
    }

    private void InsertWords(string[] words)
    {
        foreach (string word in words)
        {
            Node node = root;
            foreach (char c in word)
            {
                if (!node.IsExist(c))
                {
                    node.InsertChar(c, new Node());
                }

                node.IncrementCount();
                node = node.GetNext(c);
            }

            node.MarkComplete();
        }
    }

    internal class Node
    {
        private Node[] links = new Node[256];
        private int wordCompleted = 0;
        private int count = 0;

        public void InsertChar(char c, Node node)
        {
            links[c] = node;
        }

        public bool IsExist(char c)
        {
            return links[c] != null;
        }


        public void IncrementCount()
        {
            count++;
        }

        public Node GetNext(char c)
        {
            return links[c];
        }

        public void MarkComplete()
        {
            wordCompleted++;
        }

        public int getCount()
        {
            return count;
        }

        public int getCompletedWordCount()
        {
            return wordCompleted;
        }

        public void ReduceCount()
        {
            count--;
        }

        public void ReduceWordCompletedCount()
        {
            wordCompleted--;
        }
    }
}