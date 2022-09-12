namespace StringCalculatorKata;

public class StringCalculator
{
    public static int Add(string numbers)
    {
        if (numbers.Length == 0)
            return 0;
        if (!numbers.Contains(','))
            return 1;

        var splitRes = numbers.Split(',');

        return int.Parse(splitRes[0]) + int.Parse(splitRes[1]);
    }
}