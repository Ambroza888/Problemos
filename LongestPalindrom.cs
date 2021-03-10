using System;

namespace Problems
{
  public class LongestPalindrome {
    public static string solution(string s) {
      if (s.Length < 1 || s == null) return "";
        int start = 0;
        int end = 0;
        for (int i = 0; i < s.Length;i++) {
            int len1 = CheckFromMidOut(s, i, i);
            int len2 = CheckFromMidOut(s, i-1, i);
            int len = Math.Max(len1, len2);
            if (len > end) {
                start = i - len / 2;
                end = len;
            }

        }
        return s.Substring(start, end);
    }
    private static int CheckFromMidOut(string s, int left, int right) {
        if (left < 0) {
            return 1;
        }
        while(left >= 0 && right < s.Length && s[left] == s[right]) {
            left--;
            right++;
        }
        return right - left + 1 - 2;
    }
}
}