using System;

public class MaxSubarray
{
    public static void Problem()
    {
        int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        int sum = nums[0];
        int maxsum = nums[0];

        for (int i = 1; i < nums.Length; i++) 
        {
            sum = Math.Max(nums[i], sum + nums[i]);

            if (sum > maxsum)
            {
                maxsum = sum;
            }
        }

        Console.WriteLine(maxsum);
    }
}
