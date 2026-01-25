using LeetCode.Q0572.SubtreeOfAnotherTree;
using LeetCode.Test.Utils;

namespace LeetCode.Test;

public class Q0572SubtreeOfAnotherTreeTest
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(
            new int?[] { 3, 4, 5, 1, 2 },
            new int?[] { 4, 1, 2 }
        ).Returns(true);
        
        yield return new TestCaseData(
            new int?[] { 3, 4, 5, 1, 2, null, null, null, null, 0 },
            new int?[] { 4, 1, 2 }
        ).Returns(false);
    }
    
    [TestCaseSource(nameof(Cases))]
    public bool IsSubtree(int?[] rootArray, int?[] subArray)
    {
        var root = TreeNodeUtils.BuildTree(rootArray);
        var subRoot = TreeNodeUtils.BuildTree(subArray);
        
        return Solution.IsSubtree(root, subRoot);
    }
}