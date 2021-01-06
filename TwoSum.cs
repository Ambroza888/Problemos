using System;
using System.Collections.Generic;

namespace Problems
{
  class TwoSum
  {
    public static bool Naive(int[] arr, int sum)
    {
      for(int i = 0; i < arr.Length;i++)
      {
        for(int j = i+1; j < arr.Length; j++)
        {
          if(arr[i] + arr[j] == sum)
          {
            return true;
          }
        }
      }
      return false;
    }
    public static bool Good(int[] arr, int target)
    {
      HashSet<int> set = new HashSet<int>();
      foreach(int i in arr)
      {
        if(set.Contains(i))
        {
          return true;
        }
        else
        {
          set.Add(target - i);
        }
      }
      return false;
    }

    public static int[] TwoSumArray(int[] nums, int target)
    {
      Dictionary<int, int> dict = new Dictionary<int, int>();
      for(int i = 0; i < nums.Length; i++)
      {
        var num = nums[i];
        var differens = target - nums[i];
        if (dict.ContainsKey(differens))
        {
          return new int[] {i, dict[differens]};
        }

        if (!dict.ContainsKey(num))
        {
          dict.Add(num, i);
        }
      }
      return null;
    }

  }
}