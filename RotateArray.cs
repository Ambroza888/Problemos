namespace Problems
{
  class RotateArray
  {
    public static void Solution(int[] nums, int k)
    {
      int n = nums.Length;
        int[] result = new int[n];
        for(int i = 0; i < n;i++)
        {
            result[(i+k)%n] = nums[i];
        }
        //need to turn it back to nums[array] because is void method.
        for(int j = 0; j < n; j++)
        {
            nums[j] = result[j];
        }
    }
    public static void Solution2(int[] nums, int k)
    {
        for(int i = 0 ; i < nums.Length; i ++)
        {
            int curIndex = (i + k) % nums.Length;

            int temp = nums[curIndex];
            nums[curIndex] = nums[i];
            nums[i] = temp;
        }
    }
        public void Rotate(int[] nums, int k) {

        k = k % nums.Length;

        Reverse(0, nums.Length-1, nums);

        Reverse(0, k - 1, nums);

        Reverse(k, nums.Length-1, nums);

    }

    private void Reverse(int left, int right, int[] nums)
    {
        while (left < right)
        {
            int temp = nums[right];
            nums[right] = nums[left];
            nums[left] = temp;

            right--;
            left++;
        }
    }
  }
}