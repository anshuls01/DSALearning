namespace SlowFastPointer;

public class LengthOfCycleInCyclicLinkedList
{
    public ListNode create()
    {
        ListNode a = new ListNode(1);
        ListNode b = new ListNode(2);
        ListNode c = new ListNode(3);
        ListNode d = new ListNode(4);
        ListNode e = new ListNode(5);
        ListNode f = new ListNode(6);
        a.Next = b;
        b.Next = c;
        c.Next = d;
        d.Next = e;
        e.Next = f;
        f.Next = c;
        return a;
    }

    public int CycleLength(ListNode root)
    {
        if (root == null)
        {
            return 0;
        }

        ListNode slow = root;
        ListNode fast = root;
        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
            if (slow == fast)
            {
                ListNode pointer = slow;
               return calculateCycleLength(pointer, slow);
            }
        }

        return 0;
    }

    private int calculateCycleLength(ListNode pointer, ListNode slow)
    {
        int length = 1;
        pointer = slow.Next;
        while (pointer != slow)
        {
            pointer = pointer.Next;
            length++;
        }

        return length;
    }
}