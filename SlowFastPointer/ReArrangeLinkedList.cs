using System.Data;

namespace SlowFastPointer;

public class ReArrangeLinkedList
{
    public ListNode rearrangeList(ListNode head)
    {
        if (head == null || head.Next == null)
        {
            return head;
        }

        ListNode current = head;
        ListNode midNode = findMid(head);
        ListNode reverseListHead = reverseList(midNode);

        //midNode.Next = null; // will this affect the current node?

        while (current!=null && reverseListHead != null)
        {
            ListNode next = current.Next;
            current.Next = reverseListHead;
            current = next;

            next = reverseListHead.Next;
            reverseListHead.Next = current;
            reverseListHead = next;
        }

        if (current != null)
        {
            current.Next = null;
        }

        return head;
    }

    private ListNode reverseList(ListNode midNode)
    {
        ListNode current = midNode;
        ListNode prev = null;
        while(midNode!=null)
        {
            ListNode next = midNode.Next;
            midNode.Next = prev;
            prev = midNode;
            midNode = next;
        }

        return prev;
    }


    private ListNode findMid(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }

        return slow;
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
        return a;
    }
}