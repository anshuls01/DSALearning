namespace WarmUp;

public class ShortestWordDistance
{
    // point to be noted: Shortest, not the first difference found

    public int solution(string[]? words, string word1, string word2)
    {
        if (words == null || words.Length < 2)
        {
            return -1;
        }

        int word1Index = -1; // don't use int.MinValue, more practical value is -1, because if a word not found in array, index is -1
        int word2Index = -1; // don't use int.MinValue, more practical value is -1, because if a word not found in array, index is -1
        //int minDistance = int.MaxValue; // instead of using int.MaxValue, the max value of shortest distance between two words can be the length of array
        int minDistance = words.Length;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == word1)
            {
                word1Index = i;
            }
            if (words[i] == word2)
            {
                word2Index = i;
            }

            if (word1Index != -1 && word2Index != -1)
            {
                minDistance = Math.Min(minDistance, Math.Abs(word1Index - word2Index));
            }
        }

        return minDistance==words.Length?-1:minDistance;
    }
}