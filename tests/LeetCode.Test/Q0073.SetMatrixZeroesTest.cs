using LeetCode.Q0073.SetMatrixZeroes;

namespace LeetCode.Test;

public class Q0073SetMatrixZeroesTest
{
    private static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(
            new int[][]
            {
                [1, 1, 1],
                [1, 0, 1],
                [1, 1, 1]
            },
            new int[][]
            {
                [1, 0, 1],
                [0, 0, 0],
                [1, 0, 1]
            }
        ).SetName("TestCase1");

        yield return new TestCaseData(
            new int[][]
            {
                [0, 1, 2, 0],
                [3, 4, 5, 2],
                [1, 3, 1, 5]
            },
            new int[][]
            {
                [0, 0, 0, 0],
                [0, 4, 5, 0],
                [0, 3, 1, 0]
            }
        ).SetName("TestCase2");
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void SetZeroes(int[][] matrix, int[][] expected)
    {
        Solution.SetZeroes(matrix);
        AssertJaggedMatrixEqual(expected, matrix);
    }
    
    private static void AssertJaggedMatrixEqual(int[][] expected, int[][] actual)
    {
        Assert.That(actual, Is.Not.Null);
        Assert.That(actual, Has.Length.EqualTo(expected.Length));

        for (var i = 0; i < expected.Length; i++)
        {
            Assert.That(expected[i], Is.EqualTo(actual[i]));
        }
    }
}