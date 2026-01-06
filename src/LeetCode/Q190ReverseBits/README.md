# LeetCode 190.  ReverseBits

## Problem
https://leetcode.com/problems/reverse-bits/

## Solution
We can pick up right side bit and set it for the result and shift it to left side one by one.

```csharp
public static class Solution
{
    public static int ReverseBits(int n)
    {
        var result = 0;
        for (var i = 0; i < 32; i++)
        {
            result <<= 1;
            result |= n & 1;
            n >>= 1;
        }
        
        return result;
    }
}
```

### a <<= 1
This will shift left by one bit.
```text
example)
a      = 1011
a << 1 = 0110
```

### a & 1
This check whether the least significant bit is 1.
```text
example)
n        = ???????0  or  ???????1
1        = 00000001
-------------------
n & 1    = 00000000  or  00000001
```

### result |= n & 1
Since `n & 1 = 0 or 1` and the least significant bit of the result is `0` (we already did `<<=`), this code means it copies the least significant bit of n into the least significant bit of result


#### Time complexity `O(1)`
- The time complexity is O(1), since we always iterate 32 times.

#### Space complexity `O(1)`
- Only a constant number of variables are used.
