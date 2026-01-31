namespace LeetCode.Q0424.LongestRepeatingCharacterReplacement;

public static class Solution
{
    public static int CharacterReplacement(string s, int k)
    {
        var count = new int[26];
        var left = 0;
        var maxFreq = 0;
        var best = 0;

        for (var right = 0; right < s.Length; right++)
        {
            var idx = s[right] - 'A';
            count[idx]++;
            maxFreq = Math.Max(maxFreq, count[idx]);
            
            while ((right - left + 1) - maxFreq > k)
            {
                count[s[left] - 'A']--;
                left++;
            }

            best = Math.Max(best, right - left + 1);
        }

        return best;
    }
}