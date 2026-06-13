using System;

public class BruteFOrceMonotonicStack
{
    public static void Practice()
    {
        int[] nums = { 2, 1, 2, 4, 3 };
        int current = 0;

        int rightmax = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            current = nums[i];
            int rightGreater = current;
            bool foundGreater = false;
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] > rightGreater)
                {
                    Console.WriteLine(nums[j]);
                    foundGreater = true;
                    break;
                }
                else if (foundGreater == false && j == nums.Length - 1)
                {
                    Console.WriteLine(-1);

                }
                else if (i == nums.Length)
                {
                    Console.WriteLine(-1);
                }



            }

            if (i == nums.Length - 1)
            {
                Console.WriteLine(-1);
            }

            //   Console.WriteLine(rightmax);
        }


    }
}
