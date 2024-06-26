namespace Recursion;

public class ReverseANumber
{
    int sum = 0;
    public void Solution(int number)
    {
        if (number == 0)
        {
            Console.WriteLine(sum);
            return;
        }

        sum = sum * 10 + number % 10;
        Solution(number/10);
    }
    
    
    public void Solution2(string number, int i =0)
    {
        if (i == number.Length)
        {
            //Console.WriteLine(sum);
            return;
        }

        string a = number[i].ToString(); 
        Solution2(number, i+1);
        Console.Write(a);
    }
}