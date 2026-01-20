# LeetCode 19. RemoveNthNodeFromEndOfList

## Problem
https://leetcode.com/problems/remove-nth-node-from-end-of-list/

## Solution
### Two Pointers
1. Create `dummy -> head` (this handles the case where we need to remove the first node).
2. Move fast forward by `n + 1` steps first (so the distance between fast and slow becomes `n`).
3. Move both fast and slow together until fast reaches the end.
4. Now slow.next is the n-th node from the end, so remove it.

```csharp
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
```

#### Time complexity `O(n)`

#### Space complexity `O(1)`