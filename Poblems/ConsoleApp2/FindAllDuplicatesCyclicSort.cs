using System;

public class FindALlDuplicatesCyclicSort
{
    public static void Practice()
    {
        int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };

        int i = 0;

        while (i < nums.Length)
        {
            int correctindex = nums[i] - 1;

            if (nums[correctindex] != nums[i])
            {
                int temp = nums[i];
                nums[i] = nums[correctindex];
                nums[correctindex] = temp;
            }



            //  else if (nums[i] != nums[i+1] && correctindex != i)
            // {
            //      Console.WriteLine("duplicate  FOund " + nums[i]);
            //      break;

            //       }
            else
            {
                i++;
            }




        }

        for (int y = 1; y < nums.Length; y++)
        {

            if (nums[y - 1] != y)
            {
                Console.WriteLine(nums[y - 1]);
            }

        }


        foreach (int x in nums)
        {
            Console.WriteLine("arrayelement" + x);
        }




    }
}
