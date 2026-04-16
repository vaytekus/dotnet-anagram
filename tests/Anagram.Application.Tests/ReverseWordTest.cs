namespace Anagram.Application.Tests;

public class ReverseWordTests
{
    [Fact]
    public static void ReverseWord_ShouldReverseWord()
    {
        // Arrange
        var anagram = new AnagramChecker();
        string input = "abcd";
        string expected = "dcba";
            
        // Act
        string result = anagram.ReverseWords(input);
            
        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("trololo", "ololort")]
    [InlineData("t2est", "t2set")]
    [InlineData("a1bcd efg!h", "d1cba hgf!e")]
    [InlineData("", "")]
    public static void ReverseWords_ShouldReverseWordsMultiple(string input, string expected)
    {
        // Arrange
        var anagram = new AnagramChecker();
            
        // Act
        string result = anagram.ReverseWords(input);
            
        // Assert
        Assert.Equal(expected, result);
    }
}