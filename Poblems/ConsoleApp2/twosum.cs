using System;

class twosumproblem

    {
    public static void Main1()
    {

       
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] stored = new int[nums.Length];
        int index = 0;

        foreach (int x in nums)
        {
            int needed = target - x;

            if (Array.Exists(stored, val => val == needed))
            {
                int index1 = Array.IndexOf(nums, needed);
                int index2 = Array.IndexOf(nums, x);

                Console.WriteLine($"{index1}, {index2}");
                break;
            }

            stored[index] = x;
            index++;
        }
    }
}