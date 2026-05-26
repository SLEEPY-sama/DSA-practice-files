using System;

public class SquaresofaSortedArray
{

    public static void practice()
    {
        int[] nums = { -7, -3, 2, 3, 11 };

        int[] result = new int[nums.Length];

        int left = 0;
        int right = nums.Length - 1;

        int position = nums.Length - 1;

        while (left <= right)
        {
            int leftSquare = nums[left] * nums[left];
            int rightSquare = nums[right] * nums[right];

            if (leftSquare > rightSquare)
            {
                result[position] = leftSquare;
                left++;
            }
            else
            {
                result[position] = rightSquare;
                right--;
            }

            position--;
        }

        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}
