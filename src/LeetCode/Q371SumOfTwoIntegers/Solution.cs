namespace LeetCode.Q371SumOfTwoIntegers;

public static class Solution
{
    public static int GetSum(int a, int b) {
        while(b != 0)
        {
            var sum = a ^ b;
            var carry = (a & b) << 1;

            a = sum;
            b = carry;
        }

        return a;
    }
}