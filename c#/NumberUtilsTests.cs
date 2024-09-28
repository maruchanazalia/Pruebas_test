using Xunit;

public class NumberUtilsTests
{
    [Fact]
    public void TestIsEvenWithEvenNumber()
    {
        Assert.True(NumberUtils.IsEven(4));
    }

    [Fact]
    public void TestIsEvenWithOddNumber()
    {
        Assert.False(NumberUtils.IsEven(5));
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    [InlineData(100, true)]
    public void TestIsEvenWithMultipleCases(int number, bool expected)
    {
        Assert.Equal(expected, NumberUtils.IsEven(number));
    }
}
