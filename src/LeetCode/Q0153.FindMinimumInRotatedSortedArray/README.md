# LeetCode 153.  FindMinimumInRotatedSortedArray

## Problem
https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/

## Solution
We can solve this problem by using binary search.

```csharp
public static class Solution
{
    public static int FindMin(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] > nums[right])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return nums[left];
    }
}
```

#### Time complexity `O(log n)`
- Binary Search

#### Space complexity `O(1)`
- Only a constant number of variables are used.

