using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class AGoodNumber
    {
        public bool isGoodNumber(string digits)
        {
            // TODO: Write your code here
            return find(digits, 0);
        }

        private bool find(string digits, int index)
        {
            if (index == digits.Length)
            {
                return true;
            }

            int num = digits[index] - '0';
            if (index % 2 == 0)
            {
                bool result = isEven(num);
                if (!result)
                    return result;
            }
            else
            {
                bool result = isPrime(num, 2, num / 2);
                if (!result)
                    return result;
            }

            return find(digits, index + 1);

        }
        private bool isEven(int num)
        {
            return num % 2 == 0;
        }

        private bool isPrime(int num, int start, int end)
        {
            if (start > end)
            {
                return true;
            }
            if (num % start == 0)
            {
                return false;
            }
            return isPrime(num, start + 1, end);
        }
    }
}
