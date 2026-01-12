# LeetCode 1. TwoSum

## Problem
https://leetcode.com/problems/two-sum/description/

## Solution

### Brute force
The most straightforward approach is to use brute force to find all possible combinations.

```csharp
public static class Solution
{
    public static int[] TwoSum(int[] nums, int target)
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[j] == target - nums[i]) {
                    return new int[] { i, j };
                }
            }
        }
        
        // Return an empty array if no solution is found
        return new int[] {};
    }
}

```
#### Time complexity `O(n^2)`
Because we need to find its complement by looping through the rest of the array which takes `O(n)`.

#### Space complexity `O(1)`
The required space doesn't depend on the size of the input array.

### HashMap
To improve time complexity, we can use a hash map to register each element's complement.
While we are iterating, we can check if the current element's complement already exists in the hash table.
If it exits, we can return the answer immediately.

```csharp
public static class Solution
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
```

#### Time complexity `O(n)`
We traverse the array containing n element only once.
Each lookup in the table takes only `O(1)` time.

#### Space complexity `O(n)`
The extra space required depends on the number of items stored in the hash table, which stores at most n elements.