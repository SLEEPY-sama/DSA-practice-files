using System;

public class RemoveDuplicatesfromSortedArray
{

    public static void practice()
    {
        int[] nums = { 1, 1, 2, 2, 3, 4, 4 };

        int slow = 0;

        for (int fast = 1; fast < nums.Length; fast++)
        {
            if (nums[fast] != nums[slow])
            {
                slow++;

                nums[slow] = nums[fast];
            }
        }

        Console.WriteLine("Unique count: " + (slow + 1));

        for (int i = 0; i <= slow; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }
}
