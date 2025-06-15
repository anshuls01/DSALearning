using System.ComponentModel.DataAnnotations;

namespace LinkedLists
{
    public class StartOfLinkedListCycle
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
            ListNode a = new ListNode(1);
            ListNode b = new ListNode(2);
            a.Next = b;
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
            ListNode h = new ListNode(8);
            g.Next = h;
            h.Next = c;
            //ListNode? result = rotate(a, 3);
            findStart(a);
        }

        private void findStart(ListNode head)
        {
            if (head == null)
            {
                return;
            }
            //Find cycle if exist
            ListNode slow = head;
            ListNode fast = head;
            bool isCycle = false;
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast)
                {
                    isCycle = true;
                    break;
                }
            }
            if (!isCycle)
            {
                return;
            }

            if (isCycle)
            {
                int length = 1;
                //check cycle length
                ListNode pointer = slow.Next;
                while (pointer != slow)
                {
                    pointer = pointer.Next;
                    length++;
                }
                if (length > 0)
                {
                    ListNode pointer1 = head;
                    ListNode pointer2 = head;
                    while (length > 0)
                    {
                        pointer2 = pointer2.Next;
                        length--;
                    }
                    while (pointer1 != pointer2)
                    {
                        pointer2 = pointer2.Next;
                        pointer1 = pointer1.Next;
                    }
                    Console.WriteLine(pointer1.Val);

                }
            }

        }
    }
}
