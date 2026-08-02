namespace LeetCode._1___99;

public class _50Pow_x_n
{
    public double MyPow(double x, int n)
    {
        double result = 1.0;
        long power = n; 
        if (power < 0)
        {
            power *= -1;
            x = 1 / x;
        }
        while (power > 0)
        {
            if (power % 2 != 0)
            {
                result *= x;
            }

            x *= x;
            power /= 2;
        }

        return result;
    }
}