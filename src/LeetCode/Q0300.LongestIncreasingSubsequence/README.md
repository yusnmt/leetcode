# LeetCode 300. LongestIncreasingSubsequence

## Problem
https://leetcode.com/problems/longest-increasing-subsequence/

## Solution

### Dynamic Programing
We define `dp[i]` as follows:

`dp[i]` represents the length of the longest increasing subsequence that ends at `nums[i]`.

In other words, `dp[i]` stores the length of the LIS whose last element is at index `i`.

```csharp
public class Solution
{
    public static int LengthOfLTS(int[] nums)
    {
        var n = nums.Length;
        if (n == 0)
        {
            return 0;
        }

        var dp = new int[n];
        Array.Fill(dp, 1);

        var ans = 1;
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < i; j++) 
            {
                if (nums[j] < nums[i])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
            
            ans = Math.Max(ans, dp[i]);
        }
        
        return ans;
    }
}
```

#### Time complexity `O(n^2)`

#### Space complexity `O(n)`