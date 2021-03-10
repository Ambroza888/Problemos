using System.Collections.Generic;

namespace Problems
{
  class MajorityElement
  {
    public static int Major(int[] nums)
    {
      Dictionary<int, int> dict = new Dictionary<int, int>();
      int majorityElement = nums.Length / 2;

      foreach (int i in nums)
      {
        if (dict.ContainsKey(i))
        {
          dict[i]++;
        }
        else
        {
          dict.Add(i, 1);
        }

        if (dict[i] > majorityElement)
        {
          return i;
        }
      }
      return -1;
    }
  }
}