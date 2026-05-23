using System;

public class MaxAvarageSubarrayWithSizeK
{
    public static void practice()
    {

        int[] nums = { 1, 12, -5, -6, 50, 3 };

        int K = 4;
        int sum = 0;
        double avg = 0;
        double maxavg = double.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            avg = (double)sum / K;

            if (i >= K - 1)
            {
                sum = sum - nums[i - K + 1];
            }





            if (avg > maxavg)
            {
                maxavg = avg;
            }

            avg = sum / K;
        }
        Console.WriteLine(maxavg);



    }
}
