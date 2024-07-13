namespace Tries;

public class Node
{
    public Node[] links = new Node[26];
    public bool flag = false;

    public Node()
    {
        
    }

    public bool containsKey(char ch)
    {
        return links[ch - 'a']!=null;
    }

    public void AddChar(Node node, char c)
    {
        links[c - 'a'] = node;
    }

    public Node GetNodeAtChar(char c)
    {
        return links[c - 'a'];
    }

    public void setEnd()
    {
        flag = true;
    }

    public bool getFlag()
    {
        return flag;
    }
}