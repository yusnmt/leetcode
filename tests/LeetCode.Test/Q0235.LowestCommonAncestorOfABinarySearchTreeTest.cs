using LeetCode.Models;
using LeetCode.Q0235.LowestCommonAncestorOfABinarySearchTree;
using LeetCode.Test.Utils;

namespace LeetCode.Test;

public class Q0235LowestCommonAncestorOfABinarySearchTree
{
    public static IEnumerable<TestCaseData> Cases()
    {
        var root = TreeNodeUtils.BuildTree([6, 2, 8, 0, 4, 7, 9, null, null, 3, 5]);
        yield return new TestCaseData(
            root,
            TreeNodeUtils.FindNode(root, 2),
            TreeNodeUtils.FindNode(root, 8),
            TreeNodeUtils.FindNode(root, 6)
        ).SetName("Example1");

        yield return new TestCaseData(
            root,
            TreeNodeUtils.FindNode(root, 2),
            TreeNodeUtils.FindNode(root, 4),
            TreeNodeUtils.FindNode(root, 2)
        ).SetName("Example2");
    }
    
    [TestCaseSource(nameof(Cases))]
    public void BuildTree_Examples(TreeNode root, TreeNode p, TreeNode q, TreeNode expected)
    {
        var actual = Solution.LowestCommonAncestor(root, p, q);
        Assert.That(actual, Is.EqualTo(expected));
    }
}