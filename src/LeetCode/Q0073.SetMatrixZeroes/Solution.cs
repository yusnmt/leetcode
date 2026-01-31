namespace LeetCode.Q0073.SetMatrixZeroes;

public static class Solution
{
    public static void SetZeroes(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;

        var zeroRows = new bool[m];
        var zeroCols = new bool[n];
        
        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (matrix[i][j] == 0)
                {
                    zeroRows[i] = true;
                    zeroCols[j] = true;
                }
            }
        }
        
        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (zeroRows[i] || zeroCols[j])
                {
                    matrix[i][j] = 0;
                }
            }
        }
    }
}