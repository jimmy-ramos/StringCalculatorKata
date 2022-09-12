namespace StringCalculatorKata;

public class StringCalculator
{
    public static int Add(string numbers)
    {
        if (numbers.Length == 0)
        {
            return 0; 
        }

        if (numbers.Contains(",\n") || numbers.Contains("\n,"))
        {
            throw new InvalidDataException("Input Error: Two Delimiters cannot be put next to each other.");
        }
        
        if (numbers.EndsWith("\n"))
        {
            throw new InvalidDataException("Input Error: Ends with a break line.");
        }
        if (numbers.EndsWith(","))
        {
            throw new InvalidDataException("Input Error: Ends with a comma.");
        }
        
        numbers = numbers.Replace('\n', ',');
        
        return numbers.Split(',').Aggregate(0, (sum, current) => sum + int.Parse(current));
    }
}