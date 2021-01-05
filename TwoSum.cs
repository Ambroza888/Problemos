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
  }

}