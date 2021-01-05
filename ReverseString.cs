using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
  class ReverseString
  {
    public static void option1(string str)
    {
      //[hello] [hellh] [oellh]
      char[] s = str.ToCharArray();
      int l = str.Length/2;
      for(int i = 0; i < l ; i++)
      {
        char temp = s[i];
        s[i] = s[s.Length- 1 - i];
        s[s.Length-1- i] = temp;
      }
      s.ToString();
      foreach(char i in s) Console.Write(i);
    }
    public static void option2(string str)
    {
      char[] result = new char[str.Length]; 
    }
  }
}