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
}