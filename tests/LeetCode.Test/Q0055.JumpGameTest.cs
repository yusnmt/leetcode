
using LeetCode.Q0055.JumpGame;

namespace LeetCode.Test;

public class Q0055JumpGameTest
{
    [TestCase(new int[] { 2, 3, 1, 1, 4 }, true)]
    [TestCase(new int[] { 3, 2, 1, 0, 4 }, false)]
    public void CanJump(int[] nums, bool expected)
    {
        var result = Solution.CanJump(nums);
        Assert.That(result, Is.EqualTo(expected));
    }
}