# LeetCode 424. LongestRepeatingCharacterReplacement

## Problem
https://leetcode.com/problems/longest-repeating-character-replacement/

## Solution

### Sliding Window Approach

```csharp
public static class Solution
{
    public static int CharacterReplacement(string s, int k)
    {
        var count = new int[26];
        var left = 0;
        var maxFreq = 0;
        var best = 0;

        for (var right = 0; right < s.Length; right++)
        {
            var idx = s[right] - 'A';
            count[idx]++;
            maxFreq = Math.Max(maxFreq, count[idx]);
            
            while ((right - left + 1) - maxFreq > k)
            {
                count[s[left] - 'A']--;
                left++;
            }

            best = Math.Max(best, right - left + 1);
        }

        return best;
    }
}
```

### Good to know
`s[i] - 'A'` is a way to convert `'A'~'Z'` to `'0'~'25'` since `char` in C# is a UTF-16 number internally.

#### Time complexity `O(n)`

#### Space complexity `O(1)`