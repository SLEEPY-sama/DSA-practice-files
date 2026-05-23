using System;

public class MinimumSizeSubarraySum
{

    public static void practice()
    {

        int[] nums = { 2, 3, 1, 2, 4, 3 };

        int target = 7;
        int sum = 0;
        int leftindex = 0;
        int minlength = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            while (sum >= target)
            {



                minlength = Math.Min(minlength, i - leftindex + 1);
                sum -= nums[leftindex];

                leftindex++;

            }



        }

        Console.WriteLine("Minimum length: " + minlength);
    }
}
