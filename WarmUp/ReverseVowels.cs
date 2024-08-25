namespace WarmUp;

public class ReverseVowels
{
    // Use two pointer to swap the place for vowels
    // t: O(n), s: O(1)

    private string vowelsList = "aeiouAEIOU";
    public void solution(string str)
    {
        if (string.IsNullOrEmpty(str) || str.Length <= 1)
        {
            return;
        }

        //string is immutable so can't do char replace operation like s[start] = c
        //converted to char array
        char[] chars = str.ToCharArray(); 
        Console.WriteLine("Original string: " + string.Join("",chars));
        //HashSet<char> vowelsList = getVowels();// this can be avoided if use a simple string variable
        int start = 0;
        int end = str.Length - 1;
        while(start<end) //two pointer algo generally works best with while loop
        {
            while (start<end && !vowelsList.Contains(chars[start]))
            {
                start++;
            }
            while (end>start && !vowelsList.Contains(chars[end]))
            {
                end--;
            }

            if (end > start)
            {
                resverseChar(chars, start, end);
            }

            start++;
            end--;
        }
        
        Console.WriteLine("modified string: " + string.Join("",chars));
        
    }

    public int remove(int[] nums) {
        if(nums==null)
        {
            return 0;
        }

        if(nums.Length==1)
        {
            return 1;
        }

        int start = 0;
        int pointer = 0;

        while(start<nums.Length-2)
        {
            if(nums[start]!=nums[start+1])
            {
                nums[++pointer] = nums[start+1];
            }
            start++;
        }

        return pointer+1;

    }
    
    private void resverseChar(char[] chars, int start, int end)
    {
        (chars[end], chars[start]) = (chars[start], chars[end]);
        // char temp = chars[end];
        // chars[end] = chars[start];
        // chars[start] = temp;
    }

    //because vowels can be lower and upper case better to have complete list to match  
    private HashSet<char> getVowels()
    {
        HashSet<char> vowelsList = new HashSet<char>();
        vowelsList.Add('a');
        vowelsList.Add('A');
        vowelsList.Add('e');
        vowelsList.Add('E');
        vowelsList.Add('i');
        vowelsList.Add('I');
        vowelsList.Add('o');
        vowelsList.Add('O');
        vowelsList.Add('u');
        vowelsList.Add('U');
        return vowelsList;
    }
}