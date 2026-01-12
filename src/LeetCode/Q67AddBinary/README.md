# LeetCode 67. Addbinary

## Problem
https://leetcode.com/problems/add-binary/

## Solution
Perform per-digit addition while propagating the carry.

```csharp
public static string AddBinary(string a, string b)
{
    var i = a.Length - 1;
    var j = b.Length - 1;
    var carry = 0;

    var sb = new StringBuilder();

    while (i >= 0 || j >= 0 || carry == 1)
    {
        var sum = carry;

        if (i >= 0)
        {
            sum += a[i] - '0';
            i--;
        }

        if (j >= 0)
        {
            sum += b[j] - '0';
            j--;
        }

        sb.Append(sum % 2);
        carry = sum / 2;
    }

    var chars = sb.ToString().ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
}
```

#### Time complexity `O(Max(a.Length, b.Length))`

#### Space complexity `O(Max(a.Length, b.Length))`

## Bit Manipulation
This is a same approach as Q371 SumOfTwoIntegers.
We can follow the approach on the [README.md](../../../src/LeetCode/Q371SumOfTwoIntegers/README.md)

```csharp
public static string AddBinary_BitManipulation(string a, string b)
{
    var x = Convert.ToInt32(a, 2);
    var y = Convert.ToInt32(b, 2);

    while (y != 0)
    {
        var sum = x ^ y;
        var carry = (x & y) << 1;

        x = sum;
        y = carry;
    }

    return Convert.ToString(x, 2);
}
```

#### Time complexity `O(1)`

#### Space complexity `O(1)`