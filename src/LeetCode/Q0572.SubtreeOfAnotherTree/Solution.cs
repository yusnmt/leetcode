using LeetCode.Models;

namespace LeetCode.Q0572.SubtreeOfAnotherTree;

public static class Solution
{
    public static bool IsSubtree(TreeNode? root, TreeNode? subRoot)
    {
        if (subRoot == null)
        {
            return true;
        }

        if (root == null)
        {
            return false;
        }

        if (IsSame(root, subRoot))
        {
            return true;
        }

        return IsSubtree(root.Left, subRoot) || IsSubtree(root.Right, subRoot);
    }

    private static bool IsSame(TreeNode? a, TreeNode? b)
    {
        if (a == null && b == null)
        {
            return true;
        }

        if (a == null || b == null)
        {
            return false;
        }

        if (a.Val != b.Val)
        {
            return false;
        }

        return IsSame(a.Left, b.Left) && IsSame(a.Right, b.Right);
    }
}