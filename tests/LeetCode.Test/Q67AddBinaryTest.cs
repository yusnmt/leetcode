using LeetCode.Q67AddBinary;

namespace LeetCode.Test;

public class Q67AddBinaryTest
{
    [TestCase("11", "1", "100")]
    [TestCase("1010", "1011", "10101")]
    public void AddBinaryTest(string a, string b, string expected)
    {
        var result = Solution.AddBinary(a, b);
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [TestCase("11", "1", "100")]
    [TestCase("1010", "1011", "10101")]
    public void AddBinary_BitManipulationTest(string a, string b, string expected)
    {
        var result = Solution.AddBinary_BitManipulation(a, b);
        Assert.That(result, Is.EqualTo(expected));
    }
}