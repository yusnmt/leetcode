# LeetCode 572. SubtreeOfAnotherTree

## Problem
https://leetcode.com/problems/subtree-of-another-tree/

## Solution
Check “Same Tree” starting from every node

```csharp
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
```

#### Time complexity `O(n * m)`
- Because for each of the `n` nodes in root, we may compare up to `m` nodes in subRoot.

#### Space complexity `O(h)`
- due to the recursion call stack, where `h` is the height of the tree.
