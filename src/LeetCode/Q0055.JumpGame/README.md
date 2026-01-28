# LeetCode 55. JumpGame

## Problem
https://leetcode.com/problems/jump-game/

## Solution
The best way to solve this problem is to greedily update maxReach, which represents the farthest position reachable so far, while iterating through the array.

```csharp
public static class Solution
{
    public static bool CanJump(int[] nums)
    {
        var maxReach = 0;
        var target = nums.Length - 1;

        for (var i = 0; i < nums.Length; i++)
        {
            if (i > maxReach)
            {
                return false;
            }

            maxReach = Math.Max(maxReach, i + nums[i]);
            if (maxReach >= target)
            {
                return true;
            }
        }

        return true;
    }
}
```

#### Time complexity `O(n)`
- terate through the array once.

#### Space comIlexity `O(1)`
- Only a constant number of variables are used.
