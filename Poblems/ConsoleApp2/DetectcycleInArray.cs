using System;

public class DetectCycleinArray
{

    public static void practice()
    {
        int[] nums = { 1, 2, 3, 4, 2 };

        int slow = 0;
        int fast = 0;

        while (fast < nums.Length)
        {
            slow = nums[slow];

            fast = nums[nums[fast]];

            if (slow == fast)
            {
                Console.WriteLine("Cycle detected");
                break;
            }
        }
    }
}
