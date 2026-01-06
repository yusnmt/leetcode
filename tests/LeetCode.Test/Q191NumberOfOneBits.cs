using LeetCode.Q191NumberOfOneBits;

namespace LeetCode.Test;

public class Q191NumberOfOneBits
{
    [TestCase(11, 3)]
    [TestCase(128, 1)]
    [TestCase(2147483645, 30)]

    public void HammingWeight(int n, int expected)
    {
        var answer = Solution.HammingWeight(n);
        Assert.That(answer, Is.EqualTo(expected));
    }
}