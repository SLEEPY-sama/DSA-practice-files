public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int first = FindFirst(nums, target);

        if (first == -1)
            return new int[] { -1, -1 };

        int last = FindLast(nums, target);

        return new int[] { first, last };
    }

    private int FindFirst(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int answer = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                answer = mid;
                right = mid - 1;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return answer;
    }

    private int FindLast(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int answer = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                answer = mid;
                left = mid + 1;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return answer;
    }
}