using LeetCode.Q242ValidAnagram;

namespace LeetCode.Test;

public class Q242ValidAnagramTest
{
    [TestCase("anagram", "nagaram", true)]
    [TestCase("rat", "car", false)]

    public void IsAnagram(string s, string t, bool expected)
    {
        var answer = Solution.IsAnagram(s, t);
        Assert.That(answer, Is.EqualTo(expected));
    }
}