using System;

public class ThreeSum
{
    public static void practice()
    {
        int[] nums = { -1, 0, 1, 2, -1, -4 };
        int left = 0;
        int right = nums.Length - 2;

        Array.Sort(nums);


        for (int i = 0; i < nums.Length - 2; i++)
        {

            left = i + 1;
            right = nums.Length - 1;
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    Console.WriteLine($"Triplet found: {nums[i]}, {nums[left]}, {nums[right]}");
                    left++;
                    right--;
                }
                else if (sum < 0)
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

}