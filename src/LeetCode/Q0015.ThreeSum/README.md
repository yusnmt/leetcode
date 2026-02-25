# LeetCode 15. 3Sum

## Problem
https://leetcode.com/problems/3sum/description/

## Solution
### Sort + Two Pointers
1. Sort the array so duplicates are adjacent and two-pointer logic works correctly.
2. For each index `i`, set `left = i + 1` and `right = n - 1`, then shrink the window based on the current sum.
3. Skip duplicate values of `nums[i]` to avoid duplicate triplets in the result.
4. When a valid triplet is found, advance both pointers past any duplicate values before continuing.
5. Early exit when `nums[i] > 0` since no three sorted non-negative numbers can sum to zero.

```csharp
public class Solution
{
    public static IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var res = new List<IList<int>>();
        var n = nums.Length;

        for (var i = 0; i < n - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            if (nums[i] > 0) break;

            var left = i + 1;
            var right = n - 1;

            while (left < right)
            {
                var sum = (long)nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    res.Add(new List<int> { nums[i], nums[left], nums[right] });

                    var leftVal = nums[left];
                    var rightVal = nums[right];

                    while (left < right && nums[left] == leftVal) left++;
                    while (left < right && nums[right] == rightVal) right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return res;
    }
}
```

#### Time complexity `O(n^2)`
Sorting takes `O(n log n)`. The outer loop runs `O(n)` times, and each two-pointer pass is `O(n)`, giving `O(n^2)` overall.

#### Space complexity `O(1)`
