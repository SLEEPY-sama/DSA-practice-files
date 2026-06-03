using System;

public class CLasicMergeIntervals
{
    public static void practice()
    {
        int[][] intervals = new int[][]
        {
            new int[] {1, 3},
            new int[] {2, 6},
            new int[] {8, 10},
            new int[] {15, 18}
        };

        int currentStart = intervals[0][0];
        int currentEnd = intervals[0][1];


        for (int i = 1; i < intervals.Length; i++)
        {
            int nextStart = intervals[i][0];
            int nextEnd = intervals[i][1];

            if (currentEnd >= nextStart)
            {
                currentEnd = Math.Max(currentEnd, nextEnd);
            }
            else
            {
                Console.WriteLine($"[{currentStart}, {currentEnd}]");

                currentStart = nextStart;
                currentEnd = nextEnd;
            }
        }


    }
}
