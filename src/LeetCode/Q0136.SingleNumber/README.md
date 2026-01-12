# LeetCode 136. SingleNumber

## Problem
https://leetcode.com/problems/single-number/

## Solution

### `XOR`

| a | b | a ^ b |
|---|---|-------|
| 0 | 0 | 0     |
| 0 | 1 | 1     |
| 1 | 0 | 1     |
| 1 | 1 | 0     |

`XOR` has some the property of followings
- `a ^ a = 0`: XORing a value with itself results in zero.
- `a ^ 0 = a`: XORing a value with zero leaves the value unchanged.
- `XOR` XOR is order-independent because it satisfies the commutative and associative properties.

if the nums contains a number which doesn't appear twice, after XORing all values in the `nums`, it will be left as a result.

```csharp
public static class Solution
{
    public static int SingleNumber(int[] nums)
    {
        var result = 0;
        foreach (var num in nums)
        {
            result ^= num;
        }
        
        return result;
    }
}

```
#### Time complexity `O(n)`
Looping through the rest of the array which takes `O(n)`.

#### Space complexity `O(1)`
The required space doesn't depend on the size of the input array.

## Why does it work when the number is negative number?
In the computer, integer is represented by bits.
Negative number is represented by two's complement.

`XOR` operates on each bit independently.
It doesn't treat the sign(positive or negative) in any special way.

### Examples
```text
-3 = 11111101 (two's complement)
```

```text
  11111101
^ 11111101
---------
  00000000
```

```text
-3 ^ -3 = 0
```