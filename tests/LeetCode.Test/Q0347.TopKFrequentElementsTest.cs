using LeetCode.Q0347.TopKFrequentElements;

namespace LeetCode.Test;

public class Q347TopKFrequentElementsTest
{
    [TestCase(new[] { 1, 1, 1, 2, 2, 3 }, 2, new[] { 1, 2 })]
    [TestCase(new[] { 1 }, 1, new[] { 1 })]
    [TestCase(new[] { 1, 2, 1, 2, 1, 2, 3, 1, 3, 2 }, 2, new[] { 1, 2 })]

    public void TopKFrequent_PriorityQueue(int[] nums, int k, int[] expected)
    {
        var answer = Solution.TopKFrequent_PriorityQueue(nums, k);
        Assert.That(answer, Is.EquivalentTo(expected));
    }
    
    [TestCase(new[] { 1, 1, 1, 2, 2, 3 }, 2, new[] { 1, 2 })]
    [TestCase(new[] { 1 }, 1, new[] { 1 })]
    [TestCase(new[] { 1, 2, 1, 2, 1, 2, 3, 1, 3, 2 }, 2, new[] { 1, 2 })]

    public void TopKFrequent_BucketsSort(int[] nums, int k, int[] expected)
    {
        var answer = Solution.TopKFrequent_BucketsSort(nums, k);
        Assert.That(answer, Is.EquivalentTo(expected));
    }
}