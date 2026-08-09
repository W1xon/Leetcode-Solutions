namespace LeetCode._800_899;

public class _875KokoEatingBananas
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int left = 1;
        int right = 0;
        foreach (var banana in piles)
        {
            if (banana > right) right = banana;
        }
        while (left < right)
        {
            int middle = left + (right - left) / 2;
            long hours = 0;
            foreach (int count in piles)
            {
                hours += (count + middle - 1) / middle;
                if (hours > h)
                    break;
                
            }
            if (hours <= h)
            {
                right = middle;
            }
            else
            {
                left = middle + 1;
            }
        }
        return left;
    }
}