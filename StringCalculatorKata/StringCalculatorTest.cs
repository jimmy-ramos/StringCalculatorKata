namespace StringCalculatorKata;

public class StringCalculatorTest
{
    [Fact]
    public void ShouldAddReturn0_WhenInputIsEmpty()
    {
        var actual = StringCalculator.Add("");
        
        Assert.Equal(0, actual);
    }
}