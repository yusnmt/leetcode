namespace LeetCode.Q0048.RotateImage;

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