namespace LeetCode._1700_1799;

public class _1799MaximizeScoreAfterNOperations
{
    public int MaxScore(int[] nums)
    {
        int len = nums.Length;
        int mask = (1 << len) - 1;
        Span<int> gcdTable = stackalloc int[len * len];
        for (int i = 0; i < len; i++)
        {
            for (int j = i + 1; j < len; j++)
            {
                int val = GCD(nums[i], nums[j]);
                gcdTable[i * len + j] = val;
                gcdTable[j * len + i] = val;
            }
        }
        
        Span<int> memory = stackalloc int[mask + 1];
        return GetMaxScore(mask, 1, nums, gcdTable, memory);
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public int GetMaxScore(int mask, int index, int[] nums, Span<int> gcdTable, Span<int> memory)
    {
        if (mask == 0) return 0;
        if (memory[mask] != 0) return memory[mask];
        
        int maxScore = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if ((mask & (1 << i)) == 0)
                continue;
            
            for (int j = i + 1; j < nums.Length; j++)
            {
                if((mask & (1 << j)) == 0)
                    continue;
                int currentGcd = gcdTable[i * nums.Length + j];
                int score = index * currentGcd + GetMaxScore(mask^ (1 << i) ^ (1 << j), index + 1, nums, gcdTable, memory);

                maxScore = score > maxScore ? score : maxScore;
            }
        }
        memory[mask] = maxScore;
        return maxScore;
    }
}