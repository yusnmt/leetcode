# LeetCode 191. NumberOfOneBits

## Problem
https://leetcode.com/problems/number-of-1-bits/

## Solution
My first approach was following.
The idea is converting int value to bit format string and then iterate it. 

```csharp
public static class Solution {
    public static int HammingWeight(int n) {
        var bits = Convert.ToString(n, 2);
        var count = 0;

        foreach(var bit in bits)
        {
            if (bit == '1')
            {
                count++;
            }
        }

        return count;
    }
}
```
#### Time complexity `O(log n)`
- Convert.ToString(n, 2) - `O(log n)`
- bits.Length loop - `O(log n)`

#### Space complexity `O(log n)`
- Create new string with `log n` length - `O(log n)`

But we have another approach to use bit manipulation.
It will be more faster and cleaner than the first approach

### Bit Manipulation

To clear the lowest set bit, we can use `n & (n - 1)`.
```text
example)
n           = 1011000
n - 1       = 1010111
---------------
n & (n - 1) = 1010000
```

By repeating this approach, we can count the number of 1 bit.

```csharp
public static class Solution
{
    public static int HammingWeight(int n)
    {
        var count = 0;
        while (n != 0)
        {
            n &= n - 1;
            count++;
        }
        
        return count;
    }
}

```
#### Time complexity `O(k)`
- k = the number of 1 bit in the n.
- Th worst case will be `O(32)` since int is 32 bit.

#### Space complexity `O(1)`
- Only a constant number of variables are used.