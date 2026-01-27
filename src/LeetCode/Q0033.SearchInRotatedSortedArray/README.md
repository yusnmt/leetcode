# LeetCode 33. SearchInRotatedSortedArray

## Problem
https://leetcode.com/problems/search-in-rotated-sorted-array/

## Solution
We can solve this problem by using binary search.

```csharp
public static class Solution
{
    public static int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            
            if (nums[left] <= nums[mid])
            {
                if (nums[left] <= target && target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else
            {
                if (nums[mid] < target && target <= nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }

        return -1;
    }
}
```

#### Time complexity `O(log n)`
- Binary Search

#### Space complexity `O(1)`
- Only a constant number of variables are used.

