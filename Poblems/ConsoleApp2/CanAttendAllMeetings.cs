using System;

public class CanAttendMeetings
{
    public static void practice()
    {
        int[][] intervals = new int[][]
        {
            new int[] {0,30},
            new int [] {5,10},
            new int [] {15,20}

        };
        int currentstart = intervals[0][0];
        int currrentend = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++)
        {

            int nextStart = intervals[i][0];
            int nextEnd = intervals[i][1];
            if (currentstart < nextEnd && nextStart < currrentend)
            {
                Console.WriteLine("overlap");
            }
            else
            {
                Console.WriteLine("no overlap");
            }
        }

       ;




    }
}
