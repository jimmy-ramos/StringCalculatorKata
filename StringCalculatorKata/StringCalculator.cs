namespace StringCalculatorKata;

public class StringCalculator
{
    public static int Add(string numbers)
    {
        if (numbers.Length == 0)
        {
            return 0; 
        }
        
        if (numbers.StartsWith("\n"))
        {
            throw new InvalidDataException("Input Error: Start with a breaking line.");
        }
        if (numbers.StartsWith(","))
        {
            throw new InvalidDataException("Input Error: Start with a comma.");
        }
        if (numbers.EndsWith("\n"))
        {
            throw new InvalidDataException("Input Error: Ends with a break line.");
        }
        if (numbers.EndsWith(","))
        {
            throw new InvalidDataException("Input Error: Ends with a comma.");
        }
        if (numbers.Contains(",\n") || numbers.Contains("\n,"))
        {
            throw new InvalidDataException("Input Error: Two Delimiters cannot be put next to each other.");
        } 
        
        numbers = numbers.Replace('\n', ',');
        
        return numbers.Split(',').Aggregate(0, (sum, current) => sum + int.Parse(current));
    }
}