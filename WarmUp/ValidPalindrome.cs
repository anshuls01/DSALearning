namespace WarmUp;

public class ValidPalindrome
{
    public bool solution(string phrase)
    {
        // i can use two pointer, on the way ignore any white space, and non alphanumeric char
        // also handle upper and lower case for alpha char
        // t: O(n), s: O(1)   
        if (string.IsNullOrEmpty(phrase) || phrase.Length <= 1)
        {
            return true;
        }

        int start = 0;
        int end = phrase.Length - 1;
        while (start < end)
        {
            while (start<end && validCharNotFound(phrase[start]))
            {
                start++;
            }

            while (end>start && validCharNotFound(phrase[end]))
            {
                end--;
            }
            
            if (convertToLowerchar(phrase[start]) != convertToLowerchar(phrase[end]))
            {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }

    private char convertToLowerchar(char testChar)
    {
        bool isLower = testChar >= 'a' && testChar <= 'z';
        if (isLower)
        {
            testChar = (char)((int)testChar - 32);
        }

        return testChar;
    }

    private bool validCharNotFound(char testChar)
    {
        if (testChar == ' ')
        {
            return true;
        }

        bool isUppercase = testChar >= 'A' && testChar <= 'Z';
        bool isLowercase = testChar >= 'a' && testChar <= 'z';
        bool isNumeric = testChar >= '0' && testChar <= '9';
        return !(isUppercase || isLowercase || isNumeric);
        
    }
}