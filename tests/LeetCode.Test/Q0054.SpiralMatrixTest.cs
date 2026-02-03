using LeetCode.Q0054.SpiralMatrix;

namespace LeetCode.Test;

public class Q0054SpiralMatrixTest
{
    public static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(
            new int[][]
            {
                [1, 2, 3],
                [4, 5, 6],
                [7, 8, 9]
            },
            new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }
        ).SetName("Example1");

        yield return new TestCaseData(
            new int[][]
            {
                [1, 2, 3, 4],
                [5, 6, 7, 8],
                [9, 10, 11, 12]
            },
            new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }
        ).SetName("Example2");
    }
    
    [TestCaseSource(nameof(Cases))]
    public void SpiralOrder(int[][] matrix, int[] expected)
    {
        var result = Solution.SpiralOrder(matrix);
        
        Assert.That(result, Is.EquivalentTo(expected));
    }
}