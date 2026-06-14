using System;

public class PreviousGreaterElementMonotonicStack
{
    public static void Practice()
    {
        int[] nums = { 15, 10, 18, 12, 4, 6, 2, 8 };

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            while (stack.Count > 0 && stack.Peek() < nums[i])
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(stack.Peek());
            }
            stack.Push(nums[i]);

        }
    }
}
