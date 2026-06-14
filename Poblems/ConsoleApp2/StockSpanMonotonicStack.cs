using System;

public class StockSPanMonotonicStack
{
    public static void Practice()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < prices.Length; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(i + 1);
            }


            else
            {
                Console.WriteLine(i - stack.Peek());
            }
            stack.Push(i);
        }

    }
}
