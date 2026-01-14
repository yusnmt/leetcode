# LeetCode 152.  MaximumProductSubarray

## Problem
https://leetcode.com/problems/maximum-product-subarray/

## Solution
To solve this problem, we can start thinking from brute force.
But the time complexity will be `O(n^2)`. So we need to think about other approach.

Core point of this problem is thinking the largest product in the interval ending with i.
For example, the interval ending with `i = 3` will be
```text
          [4] =   4
      [-2, 4] =  -8
   [3, -2, 4] = -24
[2, 3, -2, 4] = -48
```

When we have next value `x = num[i]`, interval ending with `i` will be 2 options
- Start from the index: `product = x`
- Expand the interval ending with `i - 1`: `product = (product in the interval ending with i - 1) * x`

If the problem require the sum in the interval, above approach(kadane algorithm) is enough.
But we need to consider negative numbers because the max value is changed when it is multiplied by negative number.
- `big positive number * negative number = big negative number`
- `big negative number * negative number = big positive number`

So, we need to have 2 things
- maxHere: the largest product in the interval ending with `i`
- minHere: the smallest product in the interval ending with `i`

When next value `x = num[i]` comes,
- maxHere will be `Max(x, maxHere * x, minHere * x)`
- minHere will be `Min(x, maxHere * x, minHere * x)`

```csharp
public static class Solution
{
    public static int MaxProduct(int[] nums) {
        var maxHere = nums[0];
        var minHere = nums[0];
        var ans = nums[0];

        for (var i = 1; i < nums.Length; i++) {
            var x = nums[i];

            if (x < 0) {
                (maxHere, minHere) = (minHere, maxHere);
            }

            maxHere = Math.Max(x, maxHere * x);
            minHere = Math.Min(x, minHere * x);

            ans = Math.Max(ans, maxHere);
        }

        return ans;
    }
}
```

#### Time complexity `O(n)`
- One time traversal of the nums array.

#### Space complexity `O(1)`
- Only a constant number of variables are used.