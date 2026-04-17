using System;


public class Repeatednumber
{
    public static void Main()
    {
        int[] arr = new int[6];

        int[] arr1 = new int[6];

        int[] printed = new int[6];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Enter element {i + 1}:");
            arr[i] = int.Parse(Console.ReadLine());



        }

        int index = 0;
        foreach (int element in arr)
        {





            if (arr1.Contains(element))
            {

                if (printed.Contains(element))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(element);
                    printed[index] = element;



                }

            }
            arr1[index] = arr[index];
            index++;




        }
    }
}