using LeetCode.Q0105.ConstructBinaryTreeFromPreorderAndInorderTraversal;
using LeetCode.Test.Utils;

namespace LeetCode.Test;

public class Q0105ConstructBinaryTreeFromPreorderAndInorderTraversalTest
{
    public static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(
            new[] { 3, 9, 20, 15, 7 },
            new[] { 9, 3, 15, 20, 7 },
            new int?[] { 3, 9, 20, null, null, 15, 7 }
        ).SetName("Example1");

        yield return new TestCaseData(
            new[] { -1 },
            new[] { -1 },
            new int?[] { -1 }
        ).SetName("Example2");
    }
    
    [TestCaseSource(nameof(Cases))]
    public void BuildTree_Examples(int[] preorder, int[] inorder, int?[] expected)
    {
        var root = Solution.BuildTree(preorder, inorder);
        
        var actual = TreeNodeUtils.ToLevelOrderArray(root);
        Assert.That(actual, Is.EqualTo(expected));
    }
}