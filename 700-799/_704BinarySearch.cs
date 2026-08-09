namespace LeetCode._700_799;

public class _704BinarySearch
{
    public int Search(int[] nums, int target)
    {
        int len = nums.Length;
        int left = 0, right = len - 1;
        
        while (left <= right)
        {
            int middle = left + (right - left) / 2;
            if (nums[middle] == target)
            {
                return middle;
            }
            if (nums[middle] > target)
            {
                right = middle- 1;
            }
            else
            {
                left = middle + 1;
            }
        }
        
        return  -1;
    }
}