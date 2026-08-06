public class Program
{

    public static int CountValidPrices_RunFour(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string[] splitString = input.Split([','], StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            if (int.TryParse(str.Trim(), out int result))
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

        int charactersLeftOver = code.Length - 3;

        string asterisks = new string('*', charactersLeftOver);

        string lastThreeCharacters = code.Substring(charactersLeftOver);

        return asterisks + lastThreeCharacters;
    }

    public static int? FindHighestNumberBelowTarget_RunThree(int[] numbers, int target)
    {
        if(numbers is null || numbers.Length == 0)
        {
            return null;
        }

        int? highestSoFar = null;

        foreach(int digit in numbers)
        {
            if(digit < target)
            {
                if(highestSoFar is null || digit > highestSoFar)
                {
                    highestSoFar = digit;
                }
            }
        }

        return highestSoFar;
    }
    public static void Main(string[] args)
    {
        // Find The Highest Number Below Target
        Console.WriteLine(FindHighestNumberBelowTarget_RunThree([1, 5, 10, 20], 12) == 10);
        Console.WriteLine(FindHighestNumberBelowTarget_RunThree([10, 20, 30], 10) == null);
        Console.WriteLine(FindHighestNumberBelowTarget_RunThree([3, 8, 2], 9) == 8);
        Console.WriteLine(FindHighestNumberBelowTarget_RunThree([3, 8, 2], 9) == 8);
        Console.WriteLine(FindHighestNumberBelowTarget_RunThree([], 9) == null);

        // Mask Code Except Last Three:
        Console.WriteLine(MaskCodeExceptLastThree_RunThree("ABCDEFG") == "****EFG");
        Console.WriteLine(MaskCodeExceptLastThree_RunThree("123456") == "***456");
        Console.WriteLine(MaskCodeExceptLastThree_RunThree("ABC") == "ABC");
        Console.WriteLine(MaskCodeExceptLastThree_RunThree("") == "");

        //Count Valid Prices
        Console.WriteLine(CountValidPrices_RunFour("10, 20, 0, -5, hello") == 2);
        Console.WriteLine(CountValidPrices_RunFour("0, -1, abc") == 0);
        Console.WriteLine(CountValidPrices_RunFour(" 5, 15 , test, 25 ") == 3);
        Console.WriteLine(CountValidPrices_RunFour("") == 0);



        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
