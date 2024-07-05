namespace LinkedLists;

public class Node<T>
{
    public T value { get; set; }

    public Node<T> next { get; set; }

    public Node(T value)
    {
        this.value = value;
        this.next = null;
    }
}