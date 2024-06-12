namespace WarmUp;

public class Pangram
{
    public bool solution(string str)
    {
        Dictionary<char, int> alphabets = fillAlphabets();
        // foreach (char key in alphabets.Keys)
        // {
        //     Console.WriteLine(key + " " +  alphabets[key]);
        // }

        int count = 0;
        foreach (char c in str)
        {
            if (validChar(c))
            {
                //char upper = Char.ToUpper(c);
                char upper = getUpperChar(c);
                if (alphabets.ContainsKey(upper))
                {
                    alphabets[upper]++;
                    if (alphabets[upper] == 1)
                    {
                        count++;
                    }
                }
            }
        }
        return count==26;
    }

    private char getUpperChar(char c)
    {
        bool isLower = c >= 'a' && c <= 'z';
        if (isLower)
        {
            c = (char)(c - 32);
        }
        return c;
    }

    private bool validChar(char c)
    {
        bool isUpper = c >= 'A' && c <= 'Z';
        bool isLower = c >= 'a' && c <= 'z';
        return isLower || isUpper;
    }

    private Dictionary<char, int> fillAlphabets()
    {
        Dictionary<char, int> alphabets = new Dictionary<char, int>();
        for (int i = 'A'; i <= 'Z'; i++)
        {
            alphabets[(char)i] = 0;
        }

        return alphabets;
    }
}