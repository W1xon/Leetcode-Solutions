namespace LeetCode._600_699;

public class _611ValidTriangleNumber
{
    public int TriangleNumber(int[] nums)
    {
        Array.Sort(nums);
        int count = 0;
        for (int i = nums.Length - 1; i > 1; i--)
        {
            int left = 0;
            int right = i - 1;
            int c = nums[i];
            while (left < right)
            {
                int a = nums[left];
                int b = nums[right];
                if (a + b > c)
                {
                    count += right - left;
                    right--;
                }
                else
                    left++;
            }
        }

        return count;
    }
}