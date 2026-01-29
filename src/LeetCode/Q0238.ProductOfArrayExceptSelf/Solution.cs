namespace LeetCode.Q0238.ProductOfArrayExceptSelf;

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