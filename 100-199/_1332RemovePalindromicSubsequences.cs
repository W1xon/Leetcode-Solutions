namespace LeetCode._100_199;

public static class _1332RemovePalindromicSubsequences
{
    public static int RemovePalindromeSub(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return 0;
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right])
                return 2;

            left++;
            right--;
        }

        return 1;
    }
}