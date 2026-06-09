using System;

public class findDuplicateCYclicSort
{
    public static void Practice()
    {
        int[] nums = { 1, 4, 4, 3, 2 };

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
            else if (nums[i] == nums[correctindex] & i != correctindex)
            {

                Console.WriteLine("douplicate is " + nums[i]);
                break;

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
