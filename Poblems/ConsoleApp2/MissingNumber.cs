using System;

public class Missingnumber
{
    public static void findnumber()
    {
        int[] nums = { 3, 0, 1 };

        int actualsum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            actualsum += nums[i];
        }

        int expectedsum = nums.Length * (nums.Length + 1) / 2;

        int missingvalue = expectedsum - actualsum;

        Console.WriteLine(missingvalue);
    }


}
