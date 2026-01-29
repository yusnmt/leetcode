# LeetCode 238. ProductOfArrayExceptSelf

## Problem
https://leetcode.com/problems/product-of-array-except-self/

## Solution
We can think of computing the total product and dividing it by nums[i].
However, there are two exceptional cases we need to consider.

1. nums contains exactly one zero
2. nums contains two or more zeros

In the first case, only the index where nums[i] is zero will have a non-zero value in answer, which is the product of all other elements.
In the second case, all values in answer will be zero.

```csharp
public static class Solution
{
    public static int[] ProductExceptSelf(int[] nums) {
        var allProduct = 1;
        var set = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                set.Add(i);
                continue;
            }

            allProduct *= nums[i];
        }

        var answer = new int[nums.Length];
        switch (set.Count)
        {
            case > 1:
                return answer;
            case 1:
                answer[set[0]] = allProduct;
                return answer;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                continue;
            }

            answer[i] = allProduct / nums[i];
        }

        return answer;
    }
}
```

#### Time complexity `O(n)`

#### Space complexity `O(n)`
