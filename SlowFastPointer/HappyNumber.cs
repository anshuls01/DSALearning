namespace SlowFastPointer;

public class HappyNumber
{
    public bool isHappyNumber_v1(int number)
    {
        int slow = number;
        int fast = number;

        slow = SumOfNumberSquare(number);
        fast = SumOfNumberSquare(SumOfNumberSquare(fast));
        while (slow != fast)
        {
            slow = SumOfNumberSquare(slow);
            fast = SumOfNumberSquare(SumOfNumberSquare(fast));
        }

        return slow == 1;
    }

    public bool isHappyNumber(int number)
    {
        if(number==0)
        {
            return false;
        }
        if(number==1)
        {
            return true;
        }
        HashSet<int> set = new HashSet<int>();
        int sum = 0;
        bool progress = true;
        while(progress)
        {
            // ListNode node= convertToSquareList(number);
            // sum = SumOfSquareList(node);
            sum = SumOfNumberSquare(number);
            if (sum == 1)
            {
                return true;
            }
            if(set.Contains(sum))
            {
                return false;
            }
            set.Add(sum);
            number = sum;
        }
        return false;
    }

    private int SumOfNumberSquare(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int reminder = n % 10;
            n = n / 10;
            sum+=reminder * reminder;
        }

        return sum;
    }

    private ListNode convertToSquareList(int n)
    {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        while(n>0)
        {
            int reminder = n%10;
            n = n/10;
            ListNode newNode = new ListNode(reminder*reminder);
            current.Next = newNode;
            current = current.Next;

        }

        return dummy.Next;
    }

    private int SumOfSquareList(ListNode node)
    {
        ListNode current = node;
        int sum = 0;
        while(current!=null)
        {
            sum += current.Val;
            current = current.Next;
        }
        return sum;
    }

}