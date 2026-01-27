using LeetCode.Q0033.SearchInRotatedSortedArray;

namespace LeetCode.Test;

public class Q0033SearchInRotatedSortedArray
{
    [TestCase(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
    [TestCase(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
    [TestCase(new int[] { 1 }, 0, -1)]
    public void SearchTest(int[] nums, int target,  int expected)
    {
        var result = Solution.Search(nums, target);
        Assert.That(result, Is.EqualTo(expected));
    }
}