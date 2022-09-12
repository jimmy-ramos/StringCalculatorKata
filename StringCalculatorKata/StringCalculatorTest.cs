namespace StringCalculatorKata;

public class StringCalculatorTest
{
    [Fact]
    public void ShouldAddReturn0_WhenInputIsEmpty()
    {
        var actual = StringCalculator.Add("");
        
        Assert.Equal(0, actual);
    }
    
    [Fact]
    public void ShouldAddReturn1_WhenInputIs1()
    {
        var actual = StringCalculator.Add("1");
        
        Assert.Equal(1, actual);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,6", 8)]
    [InlineData("9,1000", 1009)]
    [InlineData("17,6", 23)]
    public void ShouldAddReturn8_WhenInputIs2And6(string input, int expected)
    {
        var actual = StringCalculator.Add(input);
        
        Assert.Equal(expected, actual);
    }
}