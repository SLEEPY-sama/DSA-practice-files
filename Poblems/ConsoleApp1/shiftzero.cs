using System;
using System.Security.Cryptography.X509Certificates;

public class shiftzero
{
    public static void Method1()
    {

        int[] nums = { 0, 1, 0, 3, 12 };

        int index = 0;

        for (int i = 0; i < nums.Length; i++)
        {

            if (nums[i] != 0)
            {
                int temp = nums[i];
                nums[i] = nums[index];
                nums[index] = temp;
                index++;

            }

        }


        foreach (int x in nums)
        {
            Console.WriteLine(x);
        }
    }

}