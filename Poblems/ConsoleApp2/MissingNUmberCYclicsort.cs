using System;

public class MissingNumberCyclicsort
{
    public static void Practice()
    {
        int[] nums = { 3, 0, 1 };

        int i = 0;

        while (i < nums.Length)
        {
            int correctIndex = nums[i];

            if (nums[i] < nums.Length &&
                nums[i] != nums[correctIndex])
            {
                int temp = nums[i];
                nums[i] = nums[correctIndex];
                nums[correctIndex] = temp;
            }
            else
            {
                i++;
            }
        }

        for (i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i)
            {
                Console.WriteLine(i);
                return;
            }
        }

        Console.WriteLine(nums.Length);
    }
}
