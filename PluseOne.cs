namespace Problems
{
  class PlusOne
  {
    public static int[] Plus(int[] nums)
    {
      for (int i = nums.Length -1; i >= 0; i--)
      {
        if (nums[i] < 9) {
          nums[i]++;
          return nums;
        }
        nums[i] = 0;
      }

      int[] result = new int[nums.Length + 1];
      result[0] = 1;
      for (int i = 1; i < nums.Length;i++)
      {
        result[i] = nums[i];
      }
      return result;
    }
  }
}