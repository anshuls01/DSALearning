using System.Text;

namespace Google50;

public class AddBinary
{
    public string Solve(string a, string b) {
        // ToDo: Write Your Code Here.
        string result = string.Empty;
        Stack<char> stack = new Stack<char>();
        if(a==null || a.Length==0)
        {
            return b;
        }
        if(b==null || b.Length==0)
        {
            return a;
        }
        if(a.Length<b.Length)
        {
           return Solve(b,a);
        }
        int i = 0;
        int n = a.Length-1;
        int m = b.Length-1;
        char carry = '0';
        while(i<a.Length)
        {
            char firstChar = n-i>=0?a[n-i]:'0';
            char secondChar = m-i>=0?b[m-i]:'0';
            if(firstChar=='1' && secondChar=='1')
            {
                if(carry=='1')
                {
                    stack.Push('1');
                    carry='1';
                }
                if(carry=='0')
                {
                    stack.Push('0');
                    carry='1';
                }
            }
            else if(firstChar=='1' || secondChar=='1')
            {
                if(carry=='1')
                {
                    stack.Push('0');
                    carry='1';
                }
                if(carry=='0')
                {
                    stack.Push('1');
                    carry='0';
                }
            }
            else
            {
                stack.Push(carry);
                carry='0';
            }
            i++;

        }
        if(carry!='0')
        {
            stack.Push(carry);
        }
        StringBuilder sb = new StringBuilder();
        while(stack.Count>0)
        {
            sb.Append(stack.Pop().ToString());
        }
        return sb.ToString();
    }
}