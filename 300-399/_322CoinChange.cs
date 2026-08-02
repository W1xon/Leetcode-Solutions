namespace LeetCode._300_399;

public class _322CoinChange
{
    public int CoinChange(int[] coins, int amount)
    {
        Span<int> minCoins = stackalloc int[amount + 1];
        minCoins.Fill(amount + 1); 
        minCoins[0] = 0;
        for(int j = 0; j < coins.Length; j++)
        {
            for (int i = coins[j]; i <= amount; i++)
            {
                minCoins[i] = minCoins[i] < minCoins[i - coins[j]] + 1 ? minCoins[i] : minCoins[i - coins[j]] + 1;
            }
        }
        return minCoins[amount] > amount ? -1 : minCoins[amount];
    }
}