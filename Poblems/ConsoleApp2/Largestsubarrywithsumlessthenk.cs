using System;

public class Largestsubarrywithsumlessthenk
{
    public static void practice()
    {

        int[] nums = { 4, 1, 1, 1, 2, 3, 5 };

        int k = 5;
        int sum = 0;
        int index = 0;
        int output;
        int startindex = 0;
        int endindex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum = sum + nums[i];

            while (sum > k)
            {
                sum = sum - nums[i - index];
                index++;
            }


            if (sum <= k)
            {
                startindex = i - index;
                endindex = i;
            }



        }

        Console.WriteLine(startindex + ", " + endindex);

    }
}
