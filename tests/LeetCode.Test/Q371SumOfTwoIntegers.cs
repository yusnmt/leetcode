using LeetCode.Q371SumOfTwoIntegers;

namespace LeetCode.Test;

public class Q371SumOfTwoIntegers
{
    [TestCase(1, 2, 3)]
    [TestCase(2, 3, 5)]

    public void TopKFrequent_PriorityQueue(int a, int b, int expected)
    {
        var answer = Solution.GetSum(a, b);
        Assert.That(answer, Is.EqualTo(expected));
    }
}