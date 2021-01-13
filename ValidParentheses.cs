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

    public static bool IsValid2(string s)
        {
            Stack<char> sign = new Stack<char>();

            foreach (var item in s.ToCharArray())
                if (item == '(')
                    sign.Push(')');
                else if (item == '[')
                    sign.Push(']');
                else if (item == '{')
                    sign.Push('}');
                else if (sign.Count == 0 || sign.Pop() != item)
                    return false;

            return sign.Count == 0;
        }
  }
}