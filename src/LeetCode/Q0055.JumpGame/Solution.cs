namespace LeetCode.Q0055.JumpGame;

public static class Solution
{
    public static bool CanJump(int[] nums)
    {
        var maxReach = 0;
        var target = nums.Length - 1;

        for (var i = 0; i < nums.Length; i++)
        {
            if (i > maxReach)
            {
                return false;
            }

            maxReach = Math.Max(maxReach, i + nums[i]);
            if (maxReach >= target)
            {
                return true;
            }
        }

        return true;
    }
}