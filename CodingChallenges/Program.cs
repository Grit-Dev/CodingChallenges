using System.Text;

public class Program
{
    public static int CountDigitsInString(string pInputValue)
    {
        if(string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int count = 0;

        foreach (char character in pInputValue)
        {
            if (char.IsDigit(character))
            {
                count++;
            }
        }

        return count;
    }
    public static void Main(string[] args)
    {

        Console.WriteLine(CountDigitsInString("abc123"));
        Console.WriteLine(CountDigitsInString("Cyberpunk 2077"));
        Console.WriteLine(CountDigitsInString("hello"));
        Console.WriteLine(CountDigitsInString(""));
        Console.WriteLine(CountDigitsInString(null!));
    }
}
