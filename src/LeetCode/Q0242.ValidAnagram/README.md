# LeetCode 242. ValidAnagram

## Problem
https://leetcode.com/problems/valid-anagram/

## Solution
First, if the lengths of s and t are different, they cannot be anagrams, so we return false immediately.

Next, we use a dictionary to store the frequency of each character in s.
We iterate over s and increment the count for each character.

Then, we iterate over t.
If the character exists in the dictionary, we decrement its count.
If the count becomes less than zero, it means t contains that character more times than s, so the strings are not anagrams.
If the character does not exist in the dictionary, it also means the strings are not anagrams.

If all characters are processed without any issue, the two strings are anagrams.

```csharp
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
```

#### Time complexity `O(n)`

#### Space complexity `O(n)`