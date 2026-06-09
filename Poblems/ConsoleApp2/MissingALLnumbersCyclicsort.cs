using System;

public class AllMissingNumbers
{
    public static void Practice()
    {
        int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };

        int i = 0;

        while (i < nums.Length)
        {

            int currentindex = nums[i] - 1;
            if (nums[i] != nums[currentindex])
            {
                int temp = nums[i];
                nums[i] = nums[currentindex];
                nums[currentindex] = temp;
            }

            else
            {
                i++;
            }
        }

        foreach (int x in nums)
        {
            Console.WriteLine(x);
        }

    }
}
