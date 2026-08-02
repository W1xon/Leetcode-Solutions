namespace LeetCode._400_499;

public class _438FindAllAnagramsInString
{
    public IList<int> FindAnagrams(string s, string p)
    {
        var result = new List<int>();
        if (s.Length < p.Length) return result;

        Span<int> pCount = stackalloc int[26];
        Span<int> sCount = stackalloc int[26];
        

        for (int i = 0; i < p.Length; i++)
        {
            pCount[p[i] - 'a']++;
            sCount[s[i] - 'a']++;
        }
        if(pCount.SequenceEqual(sCount))
            result.Add(0);

        for (int i = p.Length; i < s.Length; i++)
        {
            sCount[s[i] - 'a']++;
            sCount[s[i - p.Length] - 'a']--;
            if (pCount.SequenceEqual(sCount))
                result.Add(i - p.Length + 1);
        }

        return result;
    }
}