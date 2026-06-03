using System;

public class FindDuplicateNumber
{
    public static void practice()
    {
        int[] nums = { 1, 3, 4, 2, 2 };

        int slow = 0;
        int fast = 0;

        // Phase 1: detect collision
        do
        {
            slow = nums[slow];

            fast = nums[nums[fast]];

        } while (slow != fast);

        // Phase 2: find duplicate
        slow = 0;

        while (slow != fast)
        {
            slow = nums[slow];

            fast = nums[fast];
        }

        Console.WriteLine("Duplicate number: " + slow);
    }
}
