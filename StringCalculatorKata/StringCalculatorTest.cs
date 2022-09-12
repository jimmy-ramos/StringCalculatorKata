namespace StringCalculatorKata;

public class StringCalculatorTest
{
    [Fact]
    public void ShouldAddReturn0_WhenInputIsEmpty()
    {
        var actual = StringCalculator.Add("");
        
        Assert.Equal(0, actual);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,6", 8)]
    [InlineData("9,1000", 1009)]
    [InlineData("17,6", 23)]
    public void ShouldReturnSum_WhenGivenTwoPositiveNumber(string input, int expected)
    {
        var actual = StringCalculator.Add(input);
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData("1", 1)]
    [InlineData("17", 17)]
    [InlineData("3", 3)]
    [InlineData("520", 520)]
    public void ShouldReturnNumber_WhenInputIsNumber(string input, int expected)
    {
        var actual = StringCalculator.Add(input);
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData("1,2,3", 6)]
    [InlineData("17,500,1000", 1517)]
    [InlineData("3,20,400", 423)]
    [InlineData("520,10,6", 536)]
    public void ShouldReturnSum_WhenGivenThreePositivesNumbers(string input, int expected)
    {
        var actual = StringCalculator.Add(input);
        
        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("17,500,1000,10", 1527)]
    [InlineData("3,20,400,12,36", 471)]
    [InlineData("520,10,6,2,42,2", 582)]
    public void ShouldReturnSum_WhenGivenMoreThan3PositivesNumbers(string input, int expected)
    {
        var actual = StringCalculator.Add(input);
        
        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("1\n2,3", 6)]
    [InlineData("2\n5", 7)]
    public void ShouldReturnSum_WhenGivenInputWithNewLine(string input, int expected)
    {
        var actual = StringCalculator.Add(input);
        
        Assert.Equal(expected, actual);
    }
}