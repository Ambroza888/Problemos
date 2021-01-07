using System;

namespace Problems
{
  class ReverseInt
  {
    public static int reverseInt(int num)
    {
      if (num > Int32.MaxValue || num < Int32.MinValue)
      {
        return 0;
      }
      bool negative = num < 0;
      int reversed = 0;

      if (negative == true)
      {
        num = num * -1;
      }

      while (num > 0)
      {
        reversed = (reversed * 10) + (num % 10);
        num = (int)Decimal.Floor(num / 10);
      }

      return negative ? (reversed * -1) : reversed;
    }
  }
}