using System;
using System.Collections.Generic;

namespace LeetCode.Q3LongestSubstringWithoutRepeatingCharacters;

public static class Solution
{
    public static int LengthOfLongestSubstring(string s)
    {
        var set = new HashSet<char>();
        var left = 0;
        var best = 0;

        for (var right = 0; right < s.Length; right++)
        {
            while (set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }
            
            set.Add(s[right]);
            best = Math.Max(best, right - left + 1);
        }

        return best;
    }
}