namespace LeetCode._900_999;

public class _977SquaresOfASortedArray
{
    public int[] SortedSquares(int[] nums)
    { 
        int[] spanNums = new int[nums.Length];
        int index = nums.Length - 1;
        int l = 0;
        int r = index;
        while(index >= 0)
        {
            int a = nums[l] * nums[l];
            int b = nums[r] * nums[r];
            if (a > b)
            {
                spanNums[index] = a;
                l++;
            }
            else
            {
                spanNums[index] = b;
                r--;
            }

            index--;
        }
        return spanNums;
    }
}