namespace LinkedLists
{
    public class ReArrangeALinkedList
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
            ListNode head = new ListNode(1);
            ListNode b = new ListNode(2);
            head.Next = b;
            ListNode c = new ListNode(3);
            b.Next = c;
            ListNode d = new ListNode(4);
            c.Next = d;
            ListNode e = new ListNode(5);
            d.Next = e;
            ListNode f = new ListNode(6);
            e.Next = f;
            ListNode g = new ListNode(7);
            f.Next = g;
            //ListNode h = new ListNode(8);
            //g.Next = h;

            ListNode reArrangeList = reArrange(head);
            while (reArrangeList != null)
            {
                Console.Write(reArrangeList.Val + " ");
                reArrangeList = reArrangeList.Next;
            }
            Console.WriteLine();
        }

        private ListNode reArrange(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            ListNode current = head;
            ListNode mid = findMid(current);
            if (mid == current)
            {
                return current;
            }
            ListNode reverseNode = reverseList(mid);
            ListNode next = null;
            while (reverseNode != null && current != null)
            {
                next = current.Next;
                current.Next = reverseNode;
                current = next;

                next = reverseNode.Next;
                reverseNode.Next = current;
                reverseNode = next;
            }
            if (current != null)
            { current.Next = null; }
            return head;
        }

        private ListNode reverseList(ListNode midNode)
        {
            ListNode current = midNode;
            ListNode prev = null;
            ListNode next = null;
            while (midNode != null)
            {
                next = midNode.Next;
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
    }
}
