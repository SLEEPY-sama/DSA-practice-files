using System;

public class TwoSumII
{
    public static void practice()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6 };

        int target = 6;

        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int sum = nums[left] + nums[right];

            if (sum == target)
            {
                Console.WriteLine($"Found at indices {left} and {right}");
                return;
            }

            if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
    }
}
