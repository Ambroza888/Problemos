using System;
using System.Collections.Generic;

namespace Problems
{
  class VesoArray
  {
    public int length = 0;
    public static Dictionary<int,char> data;
    public VesoArray()
    {
      data = new Dictionary<int, char>();
    }

    public void get(int index)
    {
      System.Console.WriteLine( data[index] );
    }
    public void push(char item)
    {
      data[length] = item;
      // System.Console.WriteLine($"You have just pushed: {data[length]}");
      length++;
    }
    public char pop()
    {
      char lastitem = data[length-1];
      data.Remove(data[length-1]);
      length--;
      return lastitem;
    }
    public void Remove(int index)
    {
      char item = data[index];
      shiftItems(index);
    }
    void shiftItems(int index)
    {
      for(int i = index; i < length - 1; i++)
      {
        data[i] = data[i+1];
      }
      data.Remove(data[length-1]);
      length--;
    }
  }
}