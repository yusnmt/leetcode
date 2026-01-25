# LeetCode 105. ConstructBinaryTreeFromPreorderAndInorderTraversal

## Problem
https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/

## Solution
This problem is not medium level... I couldn't solve this.

```csharp
public static class Solution
{
    public static TreeNode? BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length != inorder.Length)
        {
            return null;
        }
        
        var indexMap = new Dictionary<int, int>(inorder.Length);
        for (var i = 0; i < inorder.Length; i++) {
            indexMap[inorder[i]] = i;
        }

        var preIndex = 0;

        return Build(0, inorder.Length - 1);

        TreeNode? Build(int inLeft, int inRight) {
            if (inLeft > inRight) return null;

            var rootVal = preorder[preIndex++];
            var root = new TreeNode(rootVal);

            var mid = indexMap[rootVal];

            root.Left = Build(inLeft, mid - 1);
            root.Right = Build(mid + 1, inRight);

            return root;
        }
    }
}
```

#### Time complexity `O(n)`

#### Space complexity `O(n)`