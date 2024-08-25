namespace SlowFastPointer;

public class StartOfCycle
{
    public ListNode findCycleStart(ListNode head)
    {
        if(head==null)
        {
            return null;
        }

        int cycleLength = getCycleLength(head);

        if(cycleLength==0)
        {
            return null;
        }

        return findCycleHead(head,cycleLength);
    }

    private ListNode findCycleHead(ListNode head, int length)
    {
        ListNode p1 = head;
        ListNode p2 = head;

        while(length>0)
        {
            p2 = p2.Next;
            length--;
        }

        while(p1!=p2)
        {
            p1 = p1.Next;
            p2 = p2.Next;
        }

        return p1;
    }

    private int getCycleLength(ListNode head)
    {
        int length = 0;
        ListNode slow = head;
        ListNode fast = head;
        bool cycle = false;
        
        while(fast!=null && fast.Next!=null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
            if(slow==fast)
            {
                cycle = true;
                break;
            }
        }
        
        if(!cycle)
        {
            return 0;
        }

        length = 1;
        slow = slow.Next;
        while(slow!=fast)
        {
            slow = slow.Next;
            length++;
        }
        return length;
    }

    //ListNode by default not passed by ref
    private bool CycleExist(ListNode slow,ListNode fast)
    {
        while(fast!=null && fast.Next!=null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
            if(slow==fast)
            {
                return true;
            }
        }

        return false;
    }

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
    
}