namespace LeetCode.Q0647PalindromicSubstrings;

public static class Solution
{
    public static int CountSubstrings(string s)
    {
        var n = s.Length;
        var ans = 0;

        for (var i = 0; i < n; i++)
        {
            ans += Expand(s, i, i);
            ans += Expand(s, i, i + 1);
        }

        return ans;
    }

    private static int Expand(string s, int left, int right)
    {
        var count = 0;

        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            count++;
            left--;
            right++;
        }

        return count;
    }
}