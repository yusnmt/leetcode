using LeetCode.Q0647PalindromicSubstrings;

namespace LeetCode.Test;

public class Q647PalindromicSubstringsTest
{
    [TestCase("abc", 3)]
    [TestCase("aaa", 6)]
    public void SingleNumberTest(string s, int expected)
    {
        var result = Solution.CountSubstrings(s);
        Assert.That(result, Is.EqualTo(expected));
    }
}