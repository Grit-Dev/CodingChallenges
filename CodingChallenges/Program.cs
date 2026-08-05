public class Program
{
    public static int CountValidPrices_RunThree(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string[] splitString = input.Split([','], StringSplitOptions.RemoveEmptyEntries);

        foreach (var str in splitString)
        {
            if (int.TryParse(str, out int result))
            {
                if (result > 0)
                {
                    counter++;
                }
            }
        }

        return counter;
    }

    public static string MaskCodeExceptLastThree_RunThree(string code)
    {
        if (string.IsNullOrWhiteSpace(code))
        {
            return "";
        }

        code = code.Trim();

        if (code.Length <= 3)
        {
            return code;
        }

        int indexCountLeft  = code.Length - 3;

        string asterisks = new string('*', indexCountLeft);

        string lastThreeCharacters = code.Substring(indexCountLeft);

        return asterisks + lastThreeCharacters;
    }

    public static int? FindHighestNumberBelowTarget_RunThree(int[] numbers, int target)
    {
        if(numbers is null || numbers.Length == 0)
        {
            return null;
        }

        int? highestNumberFound = null;

        foreach(int digit in numbers)
        {
            if(digit < target)
            {
                if(highestNumberFound is null || digit > highestNumberFound)
                {
                    highestNumberFound = digit;
                }
            }
        }

        return highestNumberFound;
    }
    public static void Main(string[] args)
    {
        // Find Highest Number Below Target
        Console.WriteLine(FindHighestNumberBelowTarget_RunThree([1, 5, 10, 20], 12) == 10);
        Console.WriteLine(FindHighestNumberBelowTarget_RunThree([10, 20, 30], 10) == null);
        Console.WriteLine(FindHighestNumberBelowTarget_RunThree([3, 8, 2], 9) == 8);
        Console.WriteLine(FindHighestNumberBelowTarget_RunThree([], 9) == null);

        // Mask Code Except Last Three
        // Console.WriteLine(MaskCodeExceptLastThree_RunThree("ABCDEFG") == "****EFG");
        // Console.WriteLine(MaskCodeExceptLastThree_RunThree("123456") == "***456");
        // Console.WriteLine(MaskCodeExceptLastThree_RunThree("ABC") == "ABC");
        // Console.WriteLine(MaskCodeExceptLastThree_RunThree("") == "");

        // Count Valid Prices
        // Console.WriteLine(CountValidPrices_RunThree("10, 20, 0, -5, hello") == 2);
        // Console.WriteLine(CountValidPrices_RunThree("0, -1, abc") == 0);
        // Console.WriteLine(CountValidPrices_RunThree(" 5, 15 , test, 25 ") == 3);
        // Console.WriteLine(CountValidPrices_RunThree(null!) == 0);

        //JsonDataSanitizerRunner.Run();
    }

}
