namespace Problems
{
  public class StrStr
{
    public static int Str(string haystack, string needle)
    {
        if (needle.Length == 0) return 0;
        if (needle.Length > haystack.Length) return -1;

        var needleIndex = 0;

        for(int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[needleIndex])
            {
                needleIndex++;

                if (needleIndex == needle.Length) return i - needleIndex + 1;
            }
            else
            {
                i -= needleIndex;
                needleIndex = 0;
            }
        }

        return -1;
    }
    public static int Str2(string haystack, string needle) {
        if(needle.Length == 0)
            return 0;
        int length = haystack.Length - needle.Length;
        for(int i=0; i<= length; i++)
        {
            for(int j=0; j<needle.Length; j++)
            {
           //break the loop -- if at any point character of needle and haystack does not match
                if(haystack[i+j] != needle[j])
                    break;

                if(j == needle.Length-1)
                    return i;
            }
        }
        return -1;
    }
}
}