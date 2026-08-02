namespace LeetCode._1300_1399;

public class _1342NumberOfStepsToReduceANumberToZero
{
    public int NumberOfSteps(int num) {
        
        int step = 0;
        while (num > 0)
        {
            if (num % 2 == 0)
                num /= 2;
            else
                num--;
            step++;
        }

        return step;
    }
}