namespace LeetCode.Q0190.ReverseBits;

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