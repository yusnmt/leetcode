# LeetCode 54. SpiralMatrix

## Problem
https://leetcode.com/problems/spiral-matrix/

## Solution
### Use 4 borders (top, bottom, left, right)

```csharp
public class Solution
{
    public static IList<int> SpiralOrder(int[][] matrix) {
        var m = matrix.Length;
        var n = matrix[0].Length;

        var result = new List<int>(m * n);

        int top = 0, bottom = m - 1;
        int left = 0, right = n - 1;

        while (top <= bottom && left <= right)
        {
            for (var col = left; col <= right; col++)
                result.Add(matrix[top][col]);
            top++;
            
            for (var row = top; row <= bottom; row++)
                result.Add(matrix[row][right]);
            right--;
            
            if (top <= bottom)
            {
                for (var col = right; col >= left; col--)
                    result.Add(matrix[bottom][col]);
                bottom--;
            }
            
            if (left <= right)
            {
                for (var row = bottom; row >= top; row--)
                    result.Add(matrix[row][left]);
                left++;
            }
        }

        return result;
    }
}
```

#### Time complexity `O(n * m)`

#### Space complexity `O(1)`