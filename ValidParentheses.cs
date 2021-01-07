using System.Collections.Generic;

namespace Problems
{
  class ValidParentheses
  {
    public static bool isValid(string s)
    {
      if (s == null || s == string.Empty) return true;
        Stack<char> stack = new Stack<char>();
        Dictionary<char,char> dict = new Dictionary<char,char>();

        dict.Add(')', '(');
        dict.Add(']', '[');
        dict.Add('}', '{');

        foreach(char c in s)
        {
            if (c == ']' || c =='}' || c == ')')
            {
                var check = dict[c];
                if (stack.Count > 0 && stack.Peek() == dict[c])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
  }
}