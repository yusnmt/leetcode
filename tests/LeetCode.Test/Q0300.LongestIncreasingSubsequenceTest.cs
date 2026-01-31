using LeetCode.Q0300.LongestIncreasingSubsequence;

namespace LeetCode.Test;

public class Q0300LongestIncreasingSubsequenceTest
{
    [TestCase(new[] { 10, 9, 2, 5, 3, 7, 101, 18 }, 4)]
    [TestCase(new[] { 0, 1, 0, 3, 2, 3 }, 4)]
    [TestCase(new[] { 7, 7, 7, 7, 7, 7, 7 }, 1)]

    public void LengthOfLTS(int[] nums, int expected)
    {
        var answer = Solution.LengthOfLTS(nums);
        Assert.That(answer, Is.EqualTo(expected));
    }
}