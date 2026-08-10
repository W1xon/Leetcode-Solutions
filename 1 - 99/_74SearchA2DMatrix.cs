namespace LeetCode._1___99;

public class _74SearchA2DMatrix
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        if (matrix is null || matrix.Length == 0 || matrix[0].Length == 0) 
            return false;

        int rows = matrix.Length;
        int columns = matrix[0].Length;
        int left = 0, right = (columns * rows) - 1;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;
            int n = middle / columns;
            int m = middle % columns;
            if (matrix[n][m] == target)
                return true;
            if (matrix[n][m] < target)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return false;
    }
}