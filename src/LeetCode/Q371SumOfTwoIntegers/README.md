# LeetCode 371. SumOfTwoIntegers

## Problem
https://leetcode.com/problems/sum-of-two-integers/

## Solution
Addition can actually be broken down into the following two operations:
- The sum without considering carries
- The carry itself

These can be expressed using bitwise operations.

### The sum without considering carries -> `XOR`

| a | b | a ^ b |
|---|---|-------|
| 0 | 0 | 0     |
| 0 | 1 | 1     |
| 1 | 0 | 1     |
| 1 | 1 | 0     |

```text
5 = 101
3 = 011
---------
^   110  (6)
```

### The carry itself
Carrying happen when both digits are `1`.
```scss
a & b
```
| a | b | a & b |
|---|---|-------|
| 0 | 0 | 0     |
| 0 | 1 | 0     |
| 1 | 0 | 0     |
| 1 | 1 | 1     |

```text
  101
& 011
-----
  001
```

Since a carry is shifted one bit to the left,
```scss
(a & b) << 1
```
```scss
001 << 1 = 010
```

We continue same process until carrying don't happen.


```csharp
public static class Solution
{
    public static int GetSum(int a, int b) {
        while(b != 0)
        {
            var sum = a ^ b;
            var carry = (a & b) << 1;

            a = sum;
            b = carry;
        }

        return a;
    }
}

```
#### Time complexity `O(1)`

#### Space complexity `O(1)`
