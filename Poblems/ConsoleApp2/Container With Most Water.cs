using System;

public class ContainerWithMostWater
{
    public static void practice()
    {
        int[] walls = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

        int left = 0;
        int right = walls.Length - 1;

        int maxArea = 0;

        while (left < right)
        {
            int width = right - left;

            int height = Math.Min(walls[left], walls[right]);

            int area = width * height;

            maxArea = Math.Max(maxArea, area);

            if (walls[left] < walls[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        Console.WriteLine("Maximum water: " + maxArea);
    }
}