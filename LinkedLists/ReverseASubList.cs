using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class ReverseASubList
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
        public void solve(int p, int q)
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
            ListNode h = new ListNode(8);
            g.Next = h;

            ListNode reverseList =  reverse(head, p, q);
            while (reverseList != null)
            {
                Console.Write(reverseList.Val + " ");
                reverseList = reverseList.Next;
            }
            Console.WriteLine();
        }

        private ListNode reverse(ListNode head, int p,int q)
        {
            if (p == q || head == null)
            { 
                return head;
            }

            ListNode prev = null;
            ListNode current = head;
            int i = 0;
            while (i < p - 1 && current != null)
            {
                prev = current;
                current = current.Next;
                i++;
            }

            ListNode next = null;
            ListNode pSubListPrev = prev;
            ListNode PC = current;
            q = q - p;
            while (current!=null && q>=0)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
                q--;
            }

            if (pSubListPrev != null)
            {
                pSubListPrev.Next = prev;
            }
            else
            {
                head = prev;
            }
            PC.Next = current;
            return head;
        }
    }
}
