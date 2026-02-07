using LeetCode.Q0048.RotateImage;

namespace LeetCode.Test;

public class Q0048RotateImageTest
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
            new int[][]
            {
                [7, 4, 1],
                [8, 5, 2],
                [9, 6, 3]
            }
        ).SetName("Example1");

        yield return new TestCaseData(
            new int[][]
            {
                [5, 1, 9, 11],
                [2, 4, 8, 10],
                [13, 3, 6, 7],
                [15, 14, 12, 16]
            },
            new int[][]
            {
                [15, 13, 2, 5],
                [14, 3, 4, 1],
                [12, 6, 8, 9],
                [16, 7, 10, 11]
            }
        ).SetName("Example2");
    }
    
    [TestCaseSource(nameof(Cases))]
    public void Rotate(int[][] matrix, int[][] expected)
    {
        Solution.Rotate(matrix);
        
        Assert.That(matrix, Is.EquivalentTo(expected));
    }
}