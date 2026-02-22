
using LeetCode.Q0005.LongestPalindromicSubstring;

namespace LeetCode.Test;

public static class Q0005LongestPalindromicSubstringTest
{
    [TestCase("babad", "bab")]
    [TestCase("cbbd", "bb")]
    public static void LongestPalindromicSubstring(string s, string expected)
    {
        var result = Solution.LongestPalindrome(s);
        Assert.That(result, Is.EqualTo(expected));
    }
}