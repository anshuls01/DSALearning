namespace LinkedLists
{
    /// <summary>
    /// this problem is exactly not the linked list problem
    /// but uses the slow and fast pointer concept
    /// if we square individual digit of number and sum, and repeat the process number
    /// will stuck to a cycle either 1 or sum other number
    /// if 1 than happy number else not
    /// 
    /// to solve this we have to run the slow and fast pointer until cycle not detected, 
    /// as soon as cycle detected, break the loop and check the cycle meeting point, 
    /// for happy number meeting point should be 1, else not
    /// </summary>
    public class HappyNumber
    {
        public void Solve(int num)
        {
            if (num == 0) { Console.WriteLine(false); return; }
            

            int slow = squareSumOfDigit(num);
            int fast = squareSumOfDigit(squareSumOfDigit(num));
            while (slow != fast)
            {
                slow = squareSumOfDigit(slow);
                fast = squareSumOfDigit(squareSumOfDigit(fast));
            }

            Console.WriteLine(slow==1); 
            return;
        }

        private int squareSumOfDigit(int num)
        {
            int squareSum = 0;
            while(num>0)
            {
                int reminder = num % 10;
                num = num / 10;
                squareSum += reminder*reminder;
            }
            return squareSum;
        }
    }
}
