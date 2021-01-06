using System;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] nums = new int[] {15,11,2,7};
            int target = 9;
            Console.WriteLine(TwoSum.TwoSumArray(nums, target));
        }
    }
}
