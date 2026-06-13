using System;

public class RightGreatestMonotonicStack
{
    public static void Practice()
    {
        int[] nums = { 2, 1, 2, 4, 3 };

        int[] answer = new int[nums.Length];

        Stack<int> stack = new Stack<int>();

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            while (stack.Count > 0 &&
                   stack.Peek() <= nums[i])
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                answer[i] = -1;
            }
            else
            {
                answer[i] = stack.Peek();
            }

            stack.Push(nums[i]);
        }

        foreach (int x in answer)
        {
            Console.WriteLine(x);
        }
    }
}
