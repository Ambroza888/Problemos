using System.Collections.Generic;

namespace Problems
{
  public class Anagram {
      public static bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
          return false;

        var counter = new Dictionary<char,int>();

        for (int i = 0; i < s.Length; i++)
        {
            var ch = s[i];

            if (counter.ContainsKey(ch))
            {
              counter[ch]++;
            } else {
              counter.Add(ch, 1);
            }
        }

        for (int i = 0; i < t.Length; i++)
        {
          var ch = t[i];

          if (counter.ContainsKey(ch) && counter[ch] > 0)
          {
            counter[ch]--;
          } else {
            return false;
          }
        }
        return true;
      }
  }
}