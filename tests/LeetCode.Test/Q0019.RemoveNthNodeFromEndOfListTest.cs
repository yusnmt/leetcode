using LeetCode.Q0019.RemoveNthNodeFromEndOfList;
using LeetCode.Test.Utils;

namespace LeetCode.Test;

public class Q0019RemoveNthNodeFromEndOfList
{
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 3, 5 })]
    [TestCase(new int[] { 1 }, 1, new int[] { })]
    [TestCase(new int[] { 1, 2 }, 1, new int[] { 1 })]
    public void RemoveNthFromEnd_RemovesMiddleNode(int[] values, int n, int[] expected)
    {
        var head = ListNodeUtils.BuildList(values);

        var result = Solution.RemoveNthFromEnd(head, n);

        Assert.That(ListNodeUtils.ToArray(result), Is.EqualTo(expected));
    }
}