namespace LeetCode.Q0079.WordSearch;

public static class Solution
{
    public static bool Exist(char[][] board, string word) {
        var n = board.Length;
        var m = board[0].Length;

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                var result = DFS(board, word, 0, i, j, n, m);
                if (result)
                {
                    return true;
                }
            }
        }

        return false;
    }

    private static bool DFS(char[][] board, string word, int index, int r, int c, int n, int m)
    {
        if (r < 0 || r >= n || c < 0 || c >= m) return false;
        if (board[r][c] != word[index]) return false;

        if (index == word.Length - 1) return true;

        var tmp = board[r][c];
        board[r][c] = '#';

        var found =
            DFS(board, word, index + 1, r, c - 1, n, m) ||
            DFS(board, word, index + 1, r, c + 1, n, m) ||
            DFS(board, word, index + 1, r - 1, c, n, m) ||
            DFS(board, word, index + 1, r + 1, c, n, m);

        board[r][c] = tmp;
        return found;
    }
}