# LeetCode 128. LongestConsecutiveSequence

## Problem
https://leetcode.com/problems/longest-consecutive-sequence/

## Solution
To solve this problem with `O(n)`, we can not use sort the nums array in advance.
We need to try another approach like using hash table.

My first approach was like following
```csharp
public class Solution {
    public int LongestConsecutive(int[] nums)
    { 
        var result = 0;
        var set = new HashSet<int>(nums);

        foreach (var start in set)
        {
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
```

But, this might take O(n^2) since we iterate inside the loop and we end up scanning the same consecutive range over and over again.
So, we only need to check the consecutive range when the value is the top of the range.

```csharp
public class Solution {
    public int LongestConsecutive(int[] nums)
    { 
        var result = 0;
        var set = new HashSet<int>(nums);

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
```

#### Time complexity `O(n)`
Looping through the rest of the array which takes `O(n)`.

#### Space complexity `O(n)`
HashSet