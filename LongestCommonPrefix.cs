using System.Collections;
using System.Text;

public class LongestCommonPrefix {
    public static string LongestCommonPrefiks(string[] strs) {

        StringBuilder longest = new StringBuilder();
        if (strs.Length == 0)
        {
            return longest.ToString();
        }

        string comparisonWord = strs[0];
        int comparisonIndex = 0;

        foreach (char comparisonLetter in comparisonWord)
        {
            for(int i = 1; i < strs.Length; i++)
            {
              string currentWord = strs[i];
              if (currentWord.Length -1 < comparisonIndex)
              {
                return longest.ToString();
              }
              char currentLetter = currentWord[comparisonIndex];

              if (comparisonLetter != currentLetter)
              {
                return longest.ToString();
              }
            }

            comparisonIndex++;
            longest.Append(comparisonLetter);
        }
        return longest.ToString();
    }
}