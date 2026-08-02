
using System.Runtime.CompilerServices;

namespace LeetCode._100_199;

public class _123BestTimeToBuyAndSelStock
{
    [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.AggressiveInlining)]
    public int MaxProfit(int[] prices)
    {
        int count = prices.Length;
        if (count < 2) return 0;

        Span<int> firstCost = stackalloc int[count];
        Span<int> secondCost = stackalloc int[count];
        
        firstCost[0] = 0;
        secondCost[count - 1] = 0;

        ReadOnlySpan<int> p = prices;

        int minPrice = p[0];
        int maxPrice = p[count - 1];

        for (int left = 1, i = count - 2; left < count; left++, i--)
        {
            int pLeft = p[left];
            minPrice = pLeft < minPrice ? pLeft : minPrice;
            int costLeft = pLeft - minPrice;
            firstCost[left] = costLeft > firstCost[left - 1] ? costLeft : firstCost[left - 1];

            int pRight = p[i];
            maxPrice = pRight > maxPrice ? pRight : maxPrice;
            int costRight = maxPrice - pRight;
            secondCost[i] = costRight > secondCost[i + 1] ? costRight : secondCost[i + 1];
            
            
        }
        
        int maxResult = 0;
        for (int i = 0; i < count; i++)
        {
            int result = firstCost[i] + secondCost[i];
            maxResult = result > maxResult ? result : maxResult;
        }

        return maxResult;
    }
}