namespace Problems
{
  class SqrtX
  {
    public static int MySqrt(int x)
    {
      if ( x < 2) return x;

      long left = 1;
      long right = x;

      while(left < right)
      {
        long mid = left + ((right-left) / 2);

        if (mid * mid == x)
        {
          return (int)mid;
        }
        else if (mid * mid > x)
        {
          right = mid;
        }
        else if (mid * mid < x)
        {
          left = mid + 1;
        }
      }
      return (int)left -1;
    }
  }
}