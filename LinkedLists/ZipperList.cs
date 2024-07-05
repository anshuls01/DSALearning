namespace LinkedLists;

public class ZipperList
{
    public Node<int> BuildFirstLL()
    {
        Node<int> a = new Node<int>(1);
        Node<int> b = new Node<int>(3);
        Node<int> c = new Node<int>(5);

        a.next = b;
        b.next = c;
        return a;
    }
    
    public Node<int> BuildSecondLL()
    {
        Node<int> a = new Node<int>(2);
        Node<int> b = new Node<int>(4);
        Node<int> c = new Node<int>(6);

        a.next = b;
        b.next = c;
        return a;
    }

    public Node<int> Create(Node<int> head1, Node<int> head2)
    {
        if (head1 == null)
        {
            return head2;
        }

        if (head2 == null)
        {
            return head1;
        }

        //Node<int> dummy = new Node<int>(9);
        Node<int> tail = head1;
        //dummy.next = current;
        //head1 = head1.next;
        Node<int> current1 = head1.next;
        Node<int> current2 = head2;
        int count = 0;
        while (current1 != null && current2 != null)
        {
            if (count % 2 == 0)
            {
                tail.next = current2;
                current2 = current2.next;
            }
            else
            {
                tail.next = current1;
                current1 =current1.next;
            }

            tail = tail.next;
            count++;

        }

        if (current1 == null)
        {
            tail.next = current2;
        }
        if (current2 == null)
        {
            tail.next = current1;
        }
        return head1;
    }

    public void PrintZipperList(Node<int> head)
    {
        Node<int> current = head;
        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
    }
}