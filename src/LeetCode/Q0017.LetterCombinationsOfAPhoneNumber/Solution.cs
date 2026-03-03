using System.Text;

namespace LeetCode.Q0017.LetterCombinationsOfAPhoneNumber;

public class Solution
{
    private static readonly Dictionary<char, string> PhoneMap = new()
    {
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" }
    };

    public IList<string> LetterCombinations(string digits)
    {
        var result = new List<string>();

        if (string.IsNullOrEmpty(digits))
            return result;

        Backtrack(digits, 0, new StringBuilder(), result);
        return result;
    }

    private void Backtrack(string digits, int index, StringBuilder current, List<string> result)
    {
        if (index == digits.Length)
        {
            result.Add(current.ToString());
            return;
        }
        
        foreach (var letter in PhoneMap[digits[index]])
        {
            current.Append(letter);
            Backtrack(digits, index + 1, current, result);
            current.Remove(current.Length - 1, 1);
        }
    }
}