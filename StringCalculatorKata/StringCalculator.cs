namespace StringCalculatorKata;

public class StringCalculator
{
    public static int Add(string numbers)
    {
        if (numbers.Length == 0)
        {
            return 0; 
        }
        return numbers.Split(',').Aggregate(0, (sum, current) => sum + int.Parse(current));
    }
}