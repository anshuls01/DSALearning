using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class TwoKeysKeyboard
    {

        public int findValue(int n)
        {
            int operations = 0;
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    operations += i;
                    n /= i;
                }
            }
            return operations;
            
        }
        // its not a DP problem
        //public int FindValue(int n)
        //{
        //    int steps = 0;
        //    int cc = 1;
        //    return find(n, cc, steps);
        //}

        //private int find(int n, int cc, int steps)
        //{
        //    if (cc > n)
        //    {
        //        return -1;
        //    }
        //    if (n == cc)
        //    {
        //        return steps;
        //    }

        //    int copyPasteCount = cc * 2;
        //    int pasteCount = cc + cc;
            
        //    if (copyPasteCount < n)
        //        find(n, copyPasteCount, steps + 2);

        //    if (pasteCount < n)
        //        find(n, pasteCount, steps + 1);


        //}
    }
}

