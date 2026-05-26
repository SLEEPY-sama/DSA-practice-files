using System;

public class repractice
{
    public static void practice()
    {
        int[] nums = { 2, 0, 2, 1, 1, 0 };

        int low = 0;
        int mid = 0;
        int high = nums.Length - 1;

        while (mid <= high)
        {
            // Case 0
            if (nums[mid] == 0)
            {
                int temp = nums[low];
                nums[low] = nums[mid];
                nums[mid] = temp;

                low++;
                mid++;
            }

            // Case 1
            else if (nums[mid] == 1)
            {
                mid++;
            }

            // Case 2
            else
            {
                int temp = nums[mid];
                nums[mid] = nums[high];
                nums[high] = temp;

                high--;
            }
        }

        foreach (int num in nums)
        {
            Console.Write(num + " ");
        }
    }
}