namespace LeetCode;

public static class Q1TwoSum
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>(nums.Length);
        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (map.TryGetValue(complement, out var index))
            {
                return [index, i];
            }

            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = i;
            }
        }

        return [];
    }
}