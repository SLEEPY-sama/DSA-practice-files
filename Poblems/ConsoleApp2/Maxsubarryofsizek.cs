using System;

public class Maxsubarrayofsizek
{
    public static void Problem()
    {
        int[] nums = { 2, 1, 5, 1, 3, 2 };
        int k = 3;

        int sum = 0;

        // Step 1: first window
        for (int i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        int maxsum = sum;

        // Step 2: slide window
        for (int i = k; i < nums.Length; i++)
        {
            sum = sum + nums[i] - nums[i - k];

            if (sum > maxsum)
            {
                maxsum = sum;
            }
        }

        Console.WriteLine(maxsum);
    }
}