using System;

public class Findmiddleelement
{
    public static void practice()
    {
        int[] nums = { 1, 2, 3, 4, 5 };

        int slow = 0;
        int fast = 0;

        while (fast < nums.Length && fast + 1 < nums.Length)
        {
            slow++;
            fast += 2;
        }

        Console.WriteLine(nums[slow]);
    }
}
