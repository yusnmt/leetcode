# LeetCode 235. LowestCommonAncestorOfABinarySearchTree

## Problem
https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/

## Solution
### Back Tracking
We can use back tracking to find path.

```csharp
static bool TryGetPath(TreeNode? node, TreeNode target, List<TreeNode> path)
{
    if (node is null)
        return false;

    path.Add(node);

    if (ReferenceEquals(node, target))
        return true;

    if (TryGetPath(node.Left, target, path) ||
        TryGetPath(node.Right, target, path))
        return true;

    // Remove when we go back (back tracking)
    path.RemoveAt(path.Count - 1);
    return false;
}
```

After we found two path for given `p` and `q` node, 
We can just get the lowest common ancestor.

```csharp
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
```

#### Time complexity `O(n)`
- Check each n node

#### Space complexity `O(H)`
- Call stack `O(H)`
- Path List `O(H)`