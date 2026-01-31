using LeetCode.Q0424.LongestRepeatingCharacterReplacement;

namespace LeetCode.Test;

public class Q0424LongestRepeatingCharacterReplacement
{
    [TestCase("ABAB", 2, 4)]
    [TestCase("AABABBA", 1, 4)]

    public void CharacterReplacement(string s, int k, int expected)
    {
        var answer = Solution.CharacterReplacement(s, k);
        Assert.That(answer, Is.EqualTo(expected));
    }
}