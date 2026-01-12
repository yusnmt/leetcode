using LeetCode.Q0003.LongestSubstringWithoutRepeatingCharacters;

namespace LeetCode.Test;

public class Q3LongestSubstringWithoutRepeatingCharactersTest
{
    [TestCase("abcabcbb", 3)]
    [TestCase("bbbbb", 1)]
    [TestCase("pwwkew", 3)]

    public void LengthOfLongestSubstring(string s, int expected)
    {
        var answer = Solution.LengthOfLongestSubstring(s);
        Assert.That(answer, Is.EqualTo(expected));
    }
}