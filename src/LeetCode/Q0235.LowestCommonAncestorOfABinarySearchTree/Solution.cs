using LeetCode.Models;

namespace LeetCode.Q0235.LowestCommonAncestorOfABinarySearchTree;

public static class Solution
{
    public static TreeNode? LowestCommonAncestor(TreeNode? root, TreeNode? p, TreeNode? q)
    {
        if (root is null || p is null || q is null)
            return null;

        var pathP = new List<TreeNode>();
        var pathQ = new List<TreeNode>();

        if (!TryGetPath(root, p, pathP) || !TryGetPath(root, q, pathQ))
            return null;

        TreeNode? lca = null;
        var i = 0;
        
        while (i < pathP.Count &&
               i < pathQ.Count &&
               ReferenceEquals(pathP[i], pathQ[i]))
        {
            lca = pathP[i];
            i++;
        }

        return lca;
    }

    private static bool TryGetPath(TreeNode? node, TreeNode target, List<TreeNode> path)
    {
        if (node is null)
            return false;

        path.Add(node);

        if (ReferenceEquals(node, target))
            return true;

        if (TryGetPath(node.Left, target, path) ||
            TryGetPath(node.Right, target, path))
            return true;

        path.RemoveAt(path.Count - 1);
        return false;
    }
}