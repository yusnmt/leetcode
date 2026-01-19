# LeetCode 647. PalindromicSubstrings
https://leetcode.com/problems/palindromic-substrings/

# Solution
My first approach was like followings.
2 pointer approach is one common way to check if the string is palindrome or not.
But, to check all combinations of the substring of s, it will take `O(n^2) * O(n) = O(n^3)`.
So, we need to think about another approach to reduce the time complexity.

```csharp
public class Solution
{
    public int CountSubstrings(string s)
    {
        int count = 0;

        for (int start = 0; start < s.Length; start++)
        {
            for (int end = start; end < s.Length; end++)
            {
                if (IsPalindrome(s, start, end))
                {
                    count++;
                }
            }
        }

        return count;
    }
    
    private bool IsPalindrome(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            
            left++;
            right--;
        }
        
        return true;
    }
}
```

## Expand Around Center (Center Expansion)
To count all palindromic substrings, we can use the fact that every palindrome has a center.

There are two types of palindromes:

1. Odd-length palindromes (e.g. "aba")
   - The center is a single character.
   - Example center: i
2. Even-length palindromes (e.g. "abba")
   - The center is between two characters.
   - Example center: between i and i+1

So for each index i, we try two expansions:
- Expand with center (i, i) → odd-length
- Expand with center (i, i + 1) → even-length

```csharp
public class Solution
{
    public int CountSubstrings(string s)
    {
        int n = s.Length;
        int ans = 0;

        for (int i = 0; i < n; i++)
        {
            ans += Expand(s, i, i);
            ans += Expand(s, i, i + 1);
        }

        return ans;
    }

    private int Expand(string s, int left, int right)
    {
        int count = 0;

        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            count++;
            left--;
            right++;
        }

        return count;
    }
}

```

#### Time complexity `O(n^2)`
- Because there are O(n) possible centers, and for each center we may expand outward up to O(n) times in the worst case, the total work is: `O(n) * O(n) = O(n^2)`
#### Space complexity `O(1)`
- Only a constant number of variables are used.