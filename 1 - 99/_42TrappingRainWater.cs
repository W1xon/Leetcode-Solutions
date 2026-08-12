namespace LeetCode._1___99;

public class _42TrappingRainWater
{
    public int Trap(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;

        int leftMax = height[left];
        int rightMax = height[right];
        int count = 0;
        while (left < right)
        {
            if (leftMax < rightMax)
            {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                count += leftMax - height[left];
            }
            else
            {
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                count += rightMax - height[right];
            }
        }

        return count;
    }
}