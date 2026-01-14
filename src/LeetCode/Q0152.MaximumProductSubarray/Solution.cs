using System;

namespace LeetCode.Q0152.MaximumProductSubarray;

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