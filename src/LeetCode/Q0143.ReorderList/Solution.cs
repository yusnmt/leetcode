using System;
using LeetCode.Models;

namespace LeetCode.Q0143.ReorderList;

public class Solution
{
    public void ReorderList(ListNode? head)
    {
        if (head == null || head.Next == null)
        {
            return;
        }

        ListNode slow = head;
        ListNode fast = head;

        while (fast.Next != null && fast.Next.Next != null)
        {
            if (slow == null)
            {
                throw new InvalidOperationException("slow is null");
            }
            slow = slow.Next!;
            fast = fast.Next.Next;
        }
        
        ListNode? second = slow.Next!;
        slow.Next = null;

        second = Reverse(second);
        
        ListNode first = head;
        while(second != null)
        {
            if (first == null)
            {
                throw new InvalidOperationException("first is null");
            }
            
            var temp1 = first.Next;
            var temp2 = second.Next;

            first.Next = second;
            second.Next = temp1;

            first = temp1!;
            second = temp2!;
        }
    }
    
    private static ListNode? Reverse(ListNode? head)
    {
        ListNode? prev = null;
        ListNode? curr = head;

        while (curr != null) {
            ListNode next = curr.Next!;
            curr.Next = prev;
            prev = curr;
            curr = next!;
        }

        return prev;
    }
}