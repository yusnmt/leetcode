using System.Collections.Generic;

namespace LeetCode.Q242ValidAnagram;

public static class Solution
{
    public static bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        var map = new Dictionary<char, int>();
        foreach(var c in s)
        {
            map[c] = map.TryGetValue(c, out var count) ? count + 1 : 1;
        }

        foreach(var c in t)
        {
            if (!map.ContainsKey(c))
            {
                return false;
            }

            if (--map[c] < 0)
            {
                return false;
            }    
        }

        return true;
    }
}