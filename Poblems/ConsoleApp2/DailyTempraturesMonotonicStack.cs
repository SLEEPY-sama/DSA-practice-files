using System;

public class DailyTemperaturesMonotonicStack
{
    public static void Practice()
    {
        int[] temps = { 73, 74, 75, 71, 69, 72, 76, 73 };
        Stack<int> stack = new Stack<int>();

        int counteddays = 1;
        int warmerdays = 0;


        for (int i = 0; i < temps.Length; i++)

        {
            int currentday = i;
            if (stack.Count == 0)
            {
                stack.Push(temps[i]);
            }
            while (stack.Peek() < temps[i])
            {
                stack.Push(temps[i]);
                warmerdays = i;
            }

            if (warmerdays > currentday)
            {
                counteddays = warmerdays - currentday;
                Console.WriteLine(counteddays);
            }


        }
    }
}
