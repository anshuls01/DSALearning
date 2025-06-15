
using System.Numerics;

namespace LinkedLists
{
    public class PalindromeLinkedList
    {
        public class ListNode
        {
            public int Val = 0;
            public ListNode? Next = null;

            public ListNode(int val)
            {
                this.Val = val;
            }
        }
        public void solve()
        {
            //ListNode a = new ListNode(1);

            //ListNode a = new ListNode(2);
            //ListNode b = new ListNode(4);
            //a.Next = b;
            //ListNode c = new ListNode(6);
            //b.Next = c;
            //ListNode d = new ListNode(4);
            //c.Next = d;
            //ListNode e = new ListNode(2);
            //d.Next = e;


            ListNode a = new ListNode(2);
            ListNode b = new ListNode(4);
            a.Next = b;
            ListNode c = new ListNode(6);
            b.Next = c;
            ListNode d = new ListNode(4);
            c.Next = d;
            ListNode e = new ListNode(2);
            d.Next = e;
            ListNode f = new ListNode(2);
            e.Next = f;

            bool result = findPalindrome(a);
            Console.WriteLine(result);
        }

        private bool findPalindrome(ListNode head)
        {
            if (head == null)
            {
                return false;
            }
            ListNode slow = head;
            ListNode fast = head;
            ListNode prev = null;
            while (fast != null && fast.Next != null)
            {
                prev = slow;
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            ListNode middle = null;
            if (fast == null)
            {
                middle = prev;
            }
            else
            {
                middle = slow;
            }

            // to handle single node scenario
            if (middle == head)
            {
                return true;
            }

            ListNode current = middle.Next;
            ListNode currentSubList = current;
            ListNode next = null;
            prev = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            middle.Next = prev;
            currentSubList.Next = null;

            middle = middle.Next;
            while (middle != null)
            {
                if (head.Val != middle.Val)
                {
                    return false;
                }
                head = head.Next;
                middle = middle.Next;
            }

            return true;
        }
    }
}
