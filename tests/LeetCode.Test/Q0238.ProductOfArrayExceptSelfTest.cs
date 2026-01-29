using LeetCode.Q0238.ProductOfArrayExceptSelf;

namespace LeetCode.Test;

public class Q0238ProductOfArrayExceptSelf
{
    private static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(
            new int[] { 1, 2, 3, 4 },
            new int[] { 24, 12, 8, 6 }
        );

        yield return new TestCaseData(
            new int[] { -1, 1, 0, -3, 3 },
            new int[] { 0, 0, 9, 0, 0 }
        );
    }

    [TestCaseSource(nameof(TestCases))]
    public void ProductExceptSelf(int[] nums, int[] expected)
    {
        var result = Solution.ProductExceptSelf(nums);
        Assert.That(result, Is.EqualTo(expected));
    }
}