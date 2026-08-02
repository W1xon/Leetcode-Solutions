using System.Runtime.CompilerServices;

namespace LeetCode._100_199;

public static class _125ValidPalindrome
{
    public  static bool IsPalindrome(string s)
    {
        for (int left = 0, right = s.Length - 1; left < right;)
        {
            while (left < right && !IsLetterOrDigit(s[left]))
                left++;
            while (left < right && !IsLetterOrDigit(s[right]))
                right--;

            if (left < right && ToLowerCase(s[left]) != ToLowerCase(s[right]))
                return false;

            right--;
            left++;
        }

        return true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private  static bool IsLetterOrDigit(char c)
    {
        return (c >= 'a' && c <= 'z')
               || (c >= 'A' && c <= 'Z')
               || (c >= '0' && c <= '9');
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static char ToLowerCase(char c)
    {
        if (c >= 'A' && c <= 'Z')
            return (char)(c | 0x20);
        return c;
    }
}