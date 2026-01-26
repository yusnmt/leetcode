using LeetCode.Q0153.FindMinimumInRotatedSortedArray;

namespace LeetCode.Test;

public class Q0153FindMinimumInRotatedSortedArray
{
    [TestCase(new int[] { 3, 4, 5, 1, 2 }, 1)]
    [TestCase(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0)]
    [TestCase(new int[] { 11, 13, 15, 17 }, 11)]
    public void SingleNumberTest(int[] nums, int expected)
    {
        var result = Solution.FindMin(nums);
        Assert.That(result, Is.EqualTo(expected));
    }
}