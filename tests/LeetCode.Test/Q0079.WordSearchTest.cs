using LeetCode.Q0079.WordSearch;

namespace LeetCode.Test;

public class Q0079WordSearch
{
    public static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(
            new char[][]
            {
                ['A', 'B', 'C', 'E'],
                ['S', 'F', 'C', 'S'],
                ['A', 'D', 'E', 'E']
            },
            "ABCCED",
            true
        ).SetName("Example1");

        yield return new TestCaseData(
            new char[][]
            {
                ['A', 'B', 'C', 'E'],
                ['S', 'F', 'C', 'S'],
                ['A', 'D', 'E', 'E']
            },
            "SEE",
            true
        ).SetName("Example2");
        
        yield return new TestCaseData(
            new char[][]
            {
                ['A', 'B', 'C', 'E'],
                ['S', 'F', 'C', 'S'],
                ['A', 'D', 'E', 'E']
            },
            "ABCB",
            false
        ).SetName("Example3");
    }
    
    [TestCaseSource(nameof(Cases))]
    public void Exist(char[][] board, string word, bool expected)
    {
        var result = Solution.Exist(board, word);
        
        Assert.That(result, Is.EqualTo(expected));
    }
}