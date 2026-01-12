using LeetCode.Q0136.SingleNumber;

namespace LeetCode.Test;

public class Q136SingleNumberTest
{
    [TestCase(new int[] { 2, 2, 1 }, 1)]
    [TestCase(new int[] { 4, 1, 2, 1, 2 }, 4)]
    [TestCase(new int[] { 1 }, 1)]
    public void SingleNumberTest(int[] nums, int expected)
    {
        var result = Solution.SingleNumber(nums);
        Assert.That(result, Is.EqualTo(expected));
    }
}