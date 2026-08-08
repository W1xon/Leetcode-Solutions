namespace LeetCode._700_799;

public class _739DailyTemperatures
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] diff = new int[temperatures.Length];
        Span<int> stack = stackalloc int[temperatures.Length];
        int top = 0;
        for (int i = 0; i < temperatures.Length; i++)
        {
            while (top > 0 && temperatures[stack[top - 1]] < temperatures[i])
            {
                int index = stack[--top];
                diff[index] = i - index;
            }
            stack[top++] = i;
        }

        return diff;
    }
    
    /*
    public unsafe int[] DailyTemperatures(int[] temperatures)
    {
        int length = temperatures.Length;
        int[] diff = new int[length];
        
        
        int* stack = stackalloc int[length];
        stack[0] = 0; 
        int top = 0;
        fixed(int* ptrTemps = temperatures)
            fixed(int* ptrDiff = diff)
            {
                for (int i = 1; i < length; i++)
                {
                    int currentTemp = ptrTemps[i];
                    while (top >= 0 && ptrTemps[stack[top]] < currentTemp)
                    {
                        int index = stack[top--];
                        ptrDiff[index] = i - index;
                    }

                    stack[++top] = i;
                }
            }

        return diff;
    }*/
}