namespace LeetCode.Q0005.LongestPalindromicSubstring;

public static class Solution
{
    public static string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";

        int bestL = 0, bestLen = 1;

        for (var i = 0; i < s.Length; i++)
        {
            // odd length center at i
            Expand(s, i, i, ref bestL, ref bestLen);

            // even length center between i and i+1
            Expand(s, i, i + 1, ref bestL, ref bestLen);
        }

        return s.Substring(bestL, bestLen);
    }

    private static void Expand(string s, int l, int r, ref int bestL, ref int bestLen)
    {
        while (l >= 0 && r < s.Length && s[l] == s[r])
        {
            l--;
            r++;
        }

        // now [l+1, r-1] is the max palindrome for this center
        var len = r - l - 1;
        if (len > bestLen)
        {
            bestLen = len;
            bestL = l + 1;
        }
    }
}