using LeetCode.Models;

namespace LeetCode.Test.Utils;

public static class ListNodeUtils
{
    public static ListNode BuildList(params int[] values)
    {
        if (values.Length == 0) throw new ArgumentException("values must not be empty");

        var dummy = new ListNode(0);
        var cur = dummy;

        foreach (var v in values)
        {
            cur.Next = new ListNode(v);
            cur = cur.Next;
        }

        return dummy.Next!;
    }
    
    public static int[] ToArray(ListNode? head)
    {
        var list = new List<int>();
        var cur = head;

        while (cur != null)
        {
            list.Add(cur.Val);
            cur = cur.Next;
        }

        return list.ToArray();
    }
}