# LeetCode 17. Letter Combinations of a Phone Number

## Problem
https://leetcode.com/problems/letter-combinations-of-a-phone-number/

## Solution

Uses backtracking to explore all possible letter combinations. A static phone map associates each digit with its corresponding letters, then a recursive `Backtrack` helper appends one letter at a time for the current digit, recurses to the next digit, and removes the letter on the way back — classic backtracking with a `StringBuilder` to avoid string allocation on every branch.

```csharp
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
```

#### Time complexity `O(4^n * n)`
Each digit maps to at most 4 letters, so the recursion tree has at most `4^n` leaves (where `n` is the number of digits). Building each combination string costs `O(n)`, giving `O(4^n * n)` overall.

#### Space complexity `O(n)`
The recursion depth is `n` (one frame per digit), and the `StringBuilder` holds at most `n` characters at any point. The result list itself is not counted as extra space.
