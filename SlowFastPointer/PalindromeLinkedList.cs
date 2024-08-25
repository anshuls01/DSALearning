namespace SlowFastPointer;

public class PalindromeLinkedList
{
    public bool isPalindrome(ListNode head) {
        if(head==null)
        {
            return false;
        }

        ListNode current = head;

        // find middle Node
        ListNode midNode = FindMid(head);
        
        //reverseList
        ListNode rNode = reverseList(midNode);
        
        midNode.Next = null;
        while(rNode!=null)
        {
            if(rNode.Val != current.Val)
            {
                return false;
            }
            rNode = rNode.Next;
            current = current.Next;
        }

        return true;
    }

    private ListNode FindMid(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;
        while(fast!=null && fast.Next!=null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }
        return slow;
    }

    private ListNode reverseList(ListNode node)
    {
    
        //do reverse
        ListNode prev = null;
        ListNode current = node;
        while(current!=null)
        {
            ListNode next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }
}