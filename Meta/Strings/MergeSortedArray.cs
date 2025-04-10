using System;
using System.Globalization;

namespace Meta.Strings;

public class MergeSortedArray
{
    //when i am solving I was trying to do with two pointer and shiftin the first array element to back
    // the above approch is not working
    // Another approch is to use an extra array t: O(n+m) s: O(n+m)

    public void solve_extraSpace(int[] num1,int m, int[] num2, int n)
    {
        if(num1==null || num1.Length==0)
        {
            return;
        }

        int[] temp = new int[m];
        for(int i = 0;i<m;i++)
        {
            temp[i] = num1[i];
        }

        int p = 0;//pointing to num1;
        int p1 = 0;// pointing to temp
        int p2 = 0;// pointing to num2;

        /* 
            temp: [1,2,3,0,0,0]  p:  3
            num1: [1,2,2,3,0,0]  p1: 0
            num2: [2,5,6]        p2: 1
            
        */

        while(p1<m && p2<n) 
        {
            num1[p] = Math.Min(temp[p1],num2[p2]);
            if(temp[p1]<num2[p2])
            {
                p1++;
            }
            else
            {
                p2++;
            }
            p++;
        }
        while(p1<m && p<(m+n))
        {
            num1[p] = temp[p1];
            p1++;
            p++;
        }

         while(p2<n && p<(m+n))
        {
            num1[p] = num2[p2];
            p2++;
            p++;
        }

        Console.WriteLine(string.Join(",", num1));
    }

    public void solve_withoutExtraSpace(int[] num1,int m, int[] num2, int n)
    {
        int p = n+m-1;
        int p1 = m-1;
        int p2 = n-1;
        while(p2>=0)
        {
            if(p1>=0 && num1[p1]>=num2[p2])
            {
                num1[p] = num1[p1];
                p1--;
            }
            else
            {
                 num1[p] = num2[p2];
                 p2--;
            }
            p--;
        }

        Console.WriteLine(string.Join(",",num1));
    }

}
