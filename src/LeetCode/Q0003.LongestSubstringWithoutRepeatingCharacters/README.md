# LeetCode 3. LengthOfLongestSubstring

## Problem
https://leetcode.com/problems/longest-substring-without-repeating-characters/

## Solution

To solve this problem, first approach will be finding all possible substring combinations.
But we can assume that the time complexity will be more than O(n^2).
To improve the time complexity, we can consider using something like HashSet to remember the char already appears.
And instead of looping the string many times, we can have 2 pointers like left and right, so that when we find duplicated char, we can just remove it, move left index and add new char for the HashSet.
This approach is called sliding window.

Sliding windows approach is the way to maintain a contiguous window and gradually side it to the right while updating the answer.

### Sliding Window

```csharp
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
```

#### Time complexity `O(n)`
We traverse the array containing n element only once.
Each lookup in the table takes only `O(1)` time.

#### Space complexity `O(n)`
The extra space required depends on the number of items stored in the hash table, which stores at most n elements.
More speaking strictly, the complexity will be `O(min(n, k))`, where k is the size of the character set.