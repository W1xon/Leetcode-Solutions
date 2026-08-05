namespace LeetCode._1___99;

public class _3LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        Span<int> symbols = stackalloc int[256];
        int maxLen = 0;
        for (int left = 0, right = 0; right < s.Length; right++)
        {
            char current = s[right];

            if (symbols[current] > left)
            {
                left = symbols[current];
            }

            symbols[current] = right + 1;

            int len = right - left + 1;
            maxLen = len > maxLen ? len : maxLen;
        }
        return maxLen;
    }
}