using System;

namespace Problems
{
  class Robber
  {
    public static int Rob(int[] houses)
    {
      // [1 ,2 ,3 ,4] == 6
      int[] dp = new int[houses.Length];

      dp[0] = houses[0];
      dp[1] = Math.Max(houses[0], houses[1]);

      for (int i = 2; i < houses.Length; i++)
      {
        dp[i] = Math.Max(houses[i] + dp[i - 2], dp[i -1]);
      }
      return dp[dp.Length-1];
    }
  }
}