using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Easy
{
    internal class AddBInary
    {
        public string BinarySum(string num1, string num2)
        {
            int i = num1.Length - 1;
            int j = num2.Length - 1;
            List<char> result = new List<char>();
            char Carry = '0';
            while (i >= 0 || j >= 0)
            {
                char currentCarry = '0';
                char firstChar = i>=0?num1[i]:'0';
                char secondChar = j >= 0 ? num2[j] : '0';

                char currentPChar = calulateCurrentChar(firstChar, secondChar);
                if ((firstChar == '1' && secondChar == '1') || (currentPChar=='1' && Carry=='1'))
                {
                    currentCarry = '1';
                }
                else
                {
                    currentCarry = '0';
                }

                char currentChar = calulateCurrentChar(currentPChar, Carry);
               
                Carry = currentCarry;
               
                result.Insert(0, currentChar);
                i--;
                j--;
            }
            if(Carry=='1')
            result.Insert(0, Carry);
            return string.Join("",result);
        }

        private char calulateCurrentChar(char a, char b)
        {
            if (a == b)
            {
                return '0';
            }
            else
            {
                return '1';
            }
        }


    }
}
