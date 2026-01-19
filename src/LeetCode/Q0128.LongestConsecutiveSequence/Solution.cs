using System;
using System.Collections.Generic;

namespace LeetCode.Q0128.LongestConsecutiveSequence;

public static class Solution
{
    public static int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        var result = 0;

        foreach (var start in set)
        {
            if (set.Contains(start - 1)) continue;

            var count = 1;
            var value = start;

            while (set.Contains(value + 1))
            {
                value++;
                count++;
            }

            result = Math.Max(result, count);
        }

        return result;
    }
}