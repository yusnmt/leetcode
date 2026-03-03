using LeetCode.Q0017.LetterCombinationsOfAPhoneNumber;

namespace LeetCode.Test;

public class Q17LetterCombinationsOfAPhoneNumberTest
{
    public static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(
            "23",
            new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }
        ).SetName("TwoDigits_23");

        yield return new TestCaseData(
            "2",
            new[] { "a", "b", "c" }
        ).SetName("SingleDigit_2");

        yield return new TestCaseData(
            "79",
            new[] { "pw", "px", "py", "pz", "qw", "qx", "qy", "qz", "rw", "rx", "ry", "rz", "sw", "sx", "sy", "sz" }
        ).SetName("TwoDigits_7and9_FourLetterDigits");

        yield return new TestCaseData(
            "",
            Array.Empty<string>()
        ).SetName("EmptyString_ReturnsEmpty");
    }

    [TestCaseSource(nameof(Cases))]
    public void LetterCombinations_ReturnsAllCombinations(string digits, string[] expected)
    {
        var solution = new Solution();
        var result = solution.LetterCombinations(digits);
        Assert.That(result, Is.EquivalentTo(expected));
    }
}
