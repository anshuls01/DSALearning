namespace SlidingWindow;

public class LongestSubstringAfterReplacingKChar
{
    public int findLength(string str, int k) {
        int maxLength = 0;
        // TODO: Write your code here
        int m = k;
        if(str==null|| str.Length==0)
        {
            return maxLength;
        }
        if(str.Length==k)
        {
            return k;
        }
        int start = 0;
        int end = 0;
        //Dictionary<char,int> map = new Dictionary<>char,int>();
        while(end<str.Length)
        {
            if(str[end]!=str[start])
            {
                k--;
            }
            if(k==0)
            {
                maxLength = Math.Max(maxLength, end-start+1);
            }

            if(k<0)
            {
                while(k!=m-1)
                {
                    start++;
                    k++;
                }
                k++;
            }
            end++;
        }
        maxLength = Math.Max(maxLength, end-start);
        return maxLength;
    }
}