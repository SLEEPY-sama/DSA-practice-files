using System;

public class Largestsubarray
{
	public static void Problem()
	{
		int[] nums = { 1, 2, 3, 1, 1, 1, 1 };

		int sum = 0;

		int k = 3;

		int maxsum = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			sum = sum + nums[i];

		}

		maxsum = sum;

		for (int i = k; i < nums.Length; i++)
		{
			sum = sum - nums[i - k];
			sum = sum + nums[i];

			if (sum > maxsum)
			{
				maxsum = sum;
			}

			Console.WriteLine(maxsum);	

        }


	}
}