using System;

public class MAXimumWaterTrapped
{
    public static void practice()
    {
        int[] nums = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

        int totalWater = 0;

        for (int i = 1; i < nums.Length - 1; i++)
        {
            int leftMax = 0;
            int rightMax = 0;

            // Find tallest wall on left
            for (int left = 0; left <= i; left++)
            {
                leftMax = Math.Max(leftMax, nums[left]);
            }

            // Find tallest wall on right
            for (int right = i; right < nums.Length; right++)
            {
                rightMax = Math.Max(rightMax, nums[right]);
            }

            int trappedWater = Math.Min(leftMax, rightMax) - nums[i];

            totalWater += trappedWater;
        }

        Console.WriteLine("Total trapped water: " + totalWater);
    }
}