namespace LeetCode.Test;

public class Q1TwoSumTest
{
    [TestCase(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [TestCase(new[] { 3, 3 }, 6, new[] { 0, 1 })]

    public void TwoSum(int[] nums, int target, int[] expected)
    {
        var answer = Q1TwoSum.TwoSum(nums, target);
        Assert.That(answer, Is.EqualTo(expected));
    }
}