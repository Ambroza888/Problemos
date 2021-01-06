using System;
using System.Collections.Generic;

namespace Problems
{
  class LongSubst
  {
    public static int LengthOfLongestSubstring(string s)
    {

      if (s == null || s == String.Empty)
          return 0;

      HashSet<char> set = new HashSet<char>();
      int currentMax = 0,
        i = 0,
        j = 0;

      while (j < s.Length)
        if (!set.Contains(s[j]))
        {
            set.Add(s[j]);
            j++;
            currentMax = Math.Max(currentMax, j - i);
        } else {
            set.Remove(s[i]);
            i++;
        }

      return currentMax;
    }

    public static int bruteForce(string s)
    {
      int k = 0;
      int maxLength = 0;
      for(int i = 0; i < s.Length; i++)
      {
        for (int j = k; j < i; j++)
        {
          if (s[i] == s[j])
          {
            k = j + 1;
            break;
          }
        }
        if (i - k + 1 > maxLength)
        {
            maxLength = i - k + 1;
        }
      }
      return maxLength;
    }
  }
}