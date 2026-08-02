namespace LeetCode._500_599;

public class _518CoinChange
{
    public int Change(int amount, int[] coins)
    {
        Span<int> ways = stackalloc int[amount + 1];
        ways[0] = 1;
        for(int j = 0; j < coins.Length; j++)
        {
            for (int i = coins[j]; i <= amount; i++)
            {
                ways[i] += ways[i - coins[j]];
            }
        }
        return ways[amount];
    }
}