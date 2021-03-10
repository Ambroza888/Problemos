namespace Problems
{
  class Palindrom
  {
    public static bool Palindrom1(string s)
    {
        s = s.ToLower();
        int left = 0;
        int right = s.Length - 1;
        while (left < right) {
            if (!char.IsLetterOrDigit(s[left])) {
                left++;
                continue;
            }
            if (!char.IsLetterOrDigit(s[right])) {
                right--;
                continue;
            }
            if (s[left++] != s[right--])
                return false;
        }
        return true;
    }

    public static bool Palindrom2(string s)
    {
              int left = 0;
        int right = s.Length-1;

        while(left < right)
        {
            if ( !char.IsLetterOrDigit(s[left]) )
            {
              left++;
            }
            else if ( !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }
            else
            {
                if(char.ToLower(s[left]) != char.ToLower(s[right]))
                {
                    return false;
                }
                right--;
                left++;
            }
        }
        return true;
    }
  }
}