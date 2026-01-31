namespace LeetCode.Q0300.LongestIncreasingSubsequence;

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