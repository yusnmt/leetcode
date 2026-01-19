using LeetCode.Q0128.LongestConsecutiveSequence;

namespace LeetCode.Test;

public class Q0128LongestConsecutiveSequenceTest
{
    [TestCase(new int[] { 100, 4, 200, 1, 3, 2 }, 4)]
    [TestCase(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
    [TestCase(new int[] { 1, 0, 1, 2 }, 3)]
    public void LongestConsecutiveTest(int[] nums, int expected)
    {
        var result = Solution.LongestConsecutive(nums);
        Assert.That(result, Is.EqualTo(expected));
    }
}