using LeetCode.Q0015.ThreeSum;

namespace LeetCode.Test;

public class Q0015ThreeSumTest
{
    public static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(
            new int[] { -1, 0, 1, 2, -1, -4 },
            new int[][] { [-1, -1, 2], [-1, 0, 1] }
        ).SetName("Example1");

        yield return new TestCaseData(
            new int[] { 0, 1, 1 },
            new int[][] { }
        ).SetName("Example2");

        yield return new TestCaseData(
            new int[] { 0, 0, 0 },
            new int[][] { [0, 0, 0] }
        ).SetName("Example3");
    }

    [TestCaseSource(nameof(Cases))]
    public void ThreeSum_ReturnsUniqueTriplets(int[] nums, int[][] expected)
    {
        var result = Solution.ThreeSum(nums);

        Assert.That(result.Count, Is.EqualTo(expected.Length));
        for (var i = 0; i < expected.Length; i++)
        {
            Assert.That(result[i], Is.EqualTo(expected[i]));
        }
    }
}
