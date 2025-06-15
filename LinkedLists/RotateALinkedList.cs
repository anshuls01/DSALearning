using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class RotateALinkedList
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

                //ListNode? result = rotate(a, 3);
                ListNode head =  rotate(a, 3);
                while (head != null)
                {
                    Console.Write(head.Val + " ");
                    head = head.Next;
                }
                Console.WriteLine();
            }
        private ListNode rotate(ListNode head, int k)
        {
            if (head == null || k <= 0)
            {
                return head;
            }
            ListNode current = head;
            ListNode prev = null;
            while (current != null)
            { 
                prev = current;
                current = current.Next;
            }

            prev.Next = head;

            current = head;
            prev = null;
            while (k >= 0)
            {
                prev = current;
                current = current.Next;
                k--;
            }

            prev.Next = null;
            head = current;

            return head;
        }
    }
}
