using LeetCode.Q0152.MaximumProductSubarray;

namespace LeetCode.Test;

public class Q0152MaximumProductSubarrayTest
{
    [TestCase(new int[] { 2, 3, -2, 4 }, 6)]
    [TestCase(new int[] { -2, 0, -1 }, 0)]
    public void SingleNumberTest(int[] nums, int expected)
    {
        var result = Solution.MaxProduct(nums);
        Assert.That(result, Is.EqualTo(expected));
    }
}