namespace Tries;

public class TriesCRUD
{
    private readonly Node root;

    public TriesCRUD()
    {
        this.root = new Node();
    }

    void InsertWord(string word)
    {
        Node node = root;
        foreach (char c in word)
        {
            if (!node.containsKey(c))
            {
                node.AddChar(new Node(), c);
            }

            node = node.GetNodeAtChar(c);
        }

        node.setEnd();
    }

    bool SearchWord(string word)
    {
        int i = 0;
        Node node = root;
        foreach (char c in word)
        {
            if (!node.containsKey(c))
            {
                return false;
            }
            node = node.GetNodeAtChar(c);
        }

        if (i == word.Length)
        {
            return node.getFlag();
        }

        return false;
    }

    bool wordStartsWith(string prefix)
    {
        Node node = root;
        foreach (char c in prefix)
        {
            if (!node.containsKey(c))
            {
                return false;
            }

            node = node.GetNodeAtChar(c);
        }

        return true;
    }
}