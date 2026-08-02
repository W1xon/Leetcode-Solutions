namespace LeetCode._200_299;

public class _209MinimumSizeSubarraySum
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int minLength = int.MaxValue;
        int left = 0;
        int currentSum = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            currentSum += nums[right];

            
            while (currentSum >= target)
            {
                int len = right - left + 1;
                if (len < minLength)
                    minLength = len;

                currentSum -= nums[left];
                left++;
            }
        }

        return minLength == int.MaxValue ? 0 : minLength;
    }
}