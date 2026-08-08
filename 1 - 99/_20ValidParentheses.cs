namespace LeetCode._1___99;

public class _20ValidParentheses
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
            return false;
        Span<int> stack = stackalloc int[s.Length];
        int i = 0;
        foreach (var c in s)
        {
            if (c == '(') stack[i++] = ')';
            else if (c == '[') stack[i++] = ']';
            else if (c == '{') stack[i++] = '}';
            else if (i == 0 || stack[--i] != c) return false;
        }

        return i == 0;
    }
}