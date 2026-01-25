using LeetCode.Models;

namespace LeetCode.Q0105.ConstructBinaryTreeFromPreorderAndInorderTraversal;

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