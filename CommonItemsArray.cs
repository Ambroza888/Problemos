using System;
using System.Collections.Generic;

namespace Problems
{
  public class TwoCommonItems
  {
      //['a','b','c','x] , ['z','y''i'] -- > false
      //['a','b','c','X'] , ['z','y''X'] -- > false
    public static bool On2(int[] arr1,int[] arr2)
    {
      // O(a*b)
      foreach(int i in arr1)
      {
        foreach(int j in arr2)
        {
          if(i == j)
          {
            return true;
          }
        }
      }
      return false;
    }
    public static bool On(int[] arr1, int[] arr2)
    {
      Dictionary<int,bool> first = new Dictionary<int, bool>();
      foreach(int i in arr1)
      {
        first.Add(i,true);
      }
      foreach(int j in arr2)
      {
        if(first.ContainsKey(j))
        {
          return true;
        }
      }
      return false;
    }

    public static void Third(int[] arr1, int[] arr2)
    {
      Dictionary<int,bool> map = new Dictionary<int, bool>();
      for(int i =0; i < arr1.Length;i++)
      {
        if(!map.ContainsKey(arr1[i]))
        {
          int item = arr1[i];
          map[item] = true;
        }
      }
      foreach(int j in map.Keys)
      {
        if(map.ContainsKey(j))
        {
          System.Console.WriteLine($"found it !!!");
          break;
        }
      }
    }
    public static bool forth(int[] arr1, int[] arr2)
    {
      HashSet<int> set = new HashSet<int>();
      foreach(int i in arr1)
      {
        set.Add(i);
      }
      foreach(int j in arr2)
      {
        if(set.Contains(j))
        {
          return true;
        }
      }
      return false;
    }
  }
}