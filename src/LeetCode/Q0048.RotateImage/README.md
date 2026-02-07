# LeetCode 48. RotateImage

## Problem
https://leetcode.com/problems/rotate-image/

## Solution
To rotate an `n × m` matrix by 90 degrees clockwise in-place, we can break the problem into two simple steps:

- Transpose the matrix
- Reverse each row

This works because a 90-degree clockwise rotation maps each element:
```text
(i, j) → (j, n − 1 − i)
```

which is exactly the result of transposing the matrix and then reversing every row.
```csharp
public static class Solution
{
    public static void Rotate(int[][] matrix) {
        var n = matrix.Length;
        
        for (var i = 0; i < n; i++) {
            for (var j = i + 1; j < n; j++) {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }

        for (var i = 0; i < n; i++) {
            int left = 0, right = n - 1;
            while (left < right) {
                (matrix[i][left], matrix[i][right]) = (matrix[i][right], matrix[i][left]);
                left++;
                right--;
            }
        }
    }
}
```

#### Time complexity `O(n^2)`
- Every element is visited once during transposition and reversal.

#### Space complexity `O(1)`
- The rotation is done in-place using only constant extra space.
