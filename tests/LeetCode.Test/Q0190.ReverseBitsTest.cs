

using LeetCode.Q0190.ReverseBits;

namespace LeetCode.Test;

public class Q190ReverseBitsTest
{
    [TestCase(43261596, 964176192)]
    [TestCase(2147483644, 1073741822)]
    public void ReverseBitsTest(int n, int expected)
    {
        var result = Solution.ReverseBits(n);
        Assert.That(result, Is.EqualTo(expected));
    }
}