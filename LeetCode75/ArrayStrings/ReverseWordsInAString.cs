using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75.ArrayStrings
{
    public class ReverseWordsInAString
    {
        public string ReverseWords(string s)
        {

            if (s == null || s.Length == 0)
            {
                return s;
            }
            char[] ch = s.ToCharArray();
            reverse(ch, 0, s.Length - 1);
            int start = 0;
            int end = 0;
            int i = 0;
            while (i < ch.Length)
            {
                while (i < ch.Length && ch[i] != ' ')
                {
                    ch[end] = ch[i];
                    end++;
                    i++;
                }

                if (start < end)
                {
                    reverse(ch, start, end - 1);
                    if (end < ch.Length)
                        ch[end] = ' ';
                        end++;
                    start = end;
                }
                i++;
            }
            string result = new string(ch);
            Console.WriteLine(result);
            return s;
        }
        private void reverse(char[] ch, int start, int end)
        {

            while (start < end)
            {
                char temp = ch[start];
                ch[start] = ch[end];
                ch[end] = temp;
                end--;
                start++;
            }

        }
    }
}
