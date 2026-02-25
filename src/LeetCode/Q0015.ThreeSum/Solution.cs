namespace LeetCode.Q0015.ThreeSum;

public static class Solution
{
    public static IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var res = new List<IList<int>>();
        var n = nums.Length;

        for (var i = 0; i < n - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            
            if (nums[i] > 0) break;

            var left = i + 1;
            var right = n - 1;
            
            while (left < right)
            {
                var sum = (long)nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    res.Add(new List<int> { nums[i], nums[left], nums[right] });
                    
                    var leftVal = nums[left];
                    var rightVal = nums[right];

                    while (left < right && nums[left] == leftVal) left++;
                    while (left < right && nums[right] == rightVal) right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return res;
    }
}