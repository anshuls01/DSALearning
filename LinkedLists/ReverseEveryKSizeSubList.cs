using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{

    public class ReverseEveryKSizeSubList
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

            ListNode? result = reverse(a, 3);
            while (result != null)
            {
                Console.Write(result.Val + " ");
                result = result.Next;
            }
            Console.WriteLine();
        }

        private ListNode? reverse(ListNode? head, int k)
        {
            // TODO: Write your code here
            if (head == null || k <= 1)
            {
                return head;
            }

            ListNode? prev = null;
            ListNode? current = head;

            while (current != null)
            {
                int count = k;
                ListNode? pSublistp = prev;
                ListNode? sublistC = current;
                ListNode? next = null;
                while (count > 0 && current != null)
                {
                    next = current.Next;
                    current.Next = prev;
                    prev = current;
                    current = next;
                    count--;
                }

                if (pSublistp != null)
                {
                    pSublistp.Next = prev;
                }
                else
                {
                    head = prev;
                }

                sublistC.Next = current;
                prev = sublistC;
            }
            return head;
        }
    }
}
