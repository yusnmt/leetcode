using LeetCode.Models;

namespace LeetCode.Q0019.RemoveNthNodeFromEndOfList;

public static class Solution
{
    public static ListNode RemoveNthFromEnd(ListNode head, int n) {
        var dummy = new ListNode(0, head);

        var fast = dummy;
        var slow = dummy;
        
        for (var i = 0; i < n + 1; i++) {
            fast = fast!.Next;
        }
        
        while (fast != null) {
            fast = fast.Next;
            slow = slow!.Next;
        }
        
        slow!.Next = slow!.Next!.Next;

        return dummy!.Next!;
    }
}