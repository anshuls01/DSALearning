namespace SlowFastPointer;

public class LinkedListFindCycle
{
    public ListNode createList()
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

    public bool CycleExist(ListNode root)
    {
        if (root == null)
        {
            return false;
        }

        ListNode slow = root;
        ListNode fast = root;
        while (fast != null && fast.Next != null)
        {
            fast = fast.Next.Next;
            slow = slow.Next;
            if (slow == fast)
            {
                return true;
            }
        }

        return false;
    }

}

public class ListNode
{
    public int Val = 0;
    public ListNode Next;

    public ListNode(int value)
    {
        this.Val = value;
    }
}