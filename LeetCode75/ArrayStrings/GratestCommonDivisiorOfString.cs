namespace LeetCode75.ArrayStrings;

public class GratestCommonDivisiorOfString
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1.Length == 0 || str2.Length == 0)
        {
            return "";
        }

        if (str1 == str2)
        {
            return str1;
        }

        if (str1.Length < str2.Length)
        {
            GcdOfStrings(str2, str1);
        }

        bool result = validateInput(str1, str2);

        if (!result)
        {
            return "";
        }

        string pGcd = find(str1);
        if (pGcd.Length == 0)
        {
            return "";
        }

        int length = pGcd.Length;
        int mstr1 = str1.Length / length;
        int mstr2 = str2.Length / length;

        if (mstr1 % mstr2 == 0)
        {
            return str2;
        }
        else
        {
            return pGcd;
        }
    }

    private bool validateInput(string str1, string str2)
    {
        HashSet<char> set = new HashSet<char>();
        foreach (char c in str2)
        {
            set.Add(c);
        }

        HashSet<char> set1 = new HashSet<char>(set);
        foreach (char c in str1)
        {
            if (set.Contains(c))
            {
                if (set1.Contains(c))
                {
                    set1.Remove(c);
                }
            }
        }

        return set1.Count==0;
    }

    private string find(string str1)
    {
        char c = str1[0];
        for (int i = 1; i < str1.Length; i++)
        {
            if (str1[i] == c)
            {
                return str1.Substring(0, i);
            }
        }

        return "";
    }
}