using LeetCode.Models;

namespace LeetCode.Test.Utils;

public static class TreeNodeUtils
{
    public static TreeNode? BuildTree(int?[] values)
    {
        if (values.Length == 0 || values[0] == null) return null;

        var root = new TreeNode(values[0]!.Value);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        var i = 1;

        while (queue.Count > 0 && i < values.Length)
        {
            var current = queue.Dequeue();
            
            if (i < values.Length && values[i] != null)
            {
                current.Left = new TreeNode(values[i]!.Value);
                queue.Enqueue(current.Left);
            }
            i++;
            
            if (i < values.Length && values[i] != null)
            {
                current.Right = new TreeNode(values[i]!.Value);
                queue.Enqueue(current.Right);
            }
            i++;
        }

        return root;
    }
}
