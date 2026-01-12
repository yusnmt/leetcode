namespace LeetCode.Q0136.SingleNumber;

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