
using CodingChallenges.Challenges.Phase_03_Practical_Challenges;
using Xunit.Sdk;

public class Program
{
    public static int CountValidPrices(string input)
    {
        if(string.IsNullOrEmpty(input))
        {
            return 0;
        }

        string [] stringSplit = input.Split([','], StringSplitOptions.RemoveEmptyEntries);
        int counter = 0;

        foreach(string stringIndex in stringSplit)
        {
            if(int.TryParse(stringIndex.Trim(), out int result))
            {
                if( result > 0)
                {
                    counter++;
                }
            }
        }

        return counter;
    }

    public static string MaskCodeExceptLastThree(string code)
    {
        if(string.IsNullOrWhiteSpace(code))
        {
            return "";
        }

        if(code.Length <= 3)
        {
            return code;
        }

        int lengthLeft = code.Length - 3;

        string asterisks = new('*', lengthLeft);

        string lastThreeDigits = code.Substring(lengthLeft);

        return asterisks + lastThreeDigits;
    }

    public static int? FindHighestNumberBelowTarget(int[] numbers, int target)
    {
        if(numbers is null || numbers.Length == 0)
        {
            return null;
        }

        int? highestNumberSoFar = null;

        foreach(int digit in numbers)
        {
            if(digit < target)
            {
                if(highestNumberSoFar is null || digit > highestNumberSoFar)
                {
                    highestNumberSoFar = digit;
                }
            }
        }

        return highestNumberSoFar;
    }
    public static void Main(string[] args)
    {
        // Find Highest Number Below Target
        Console.WriteLine(FindHighestNumberBelowTarget([1, 5, 10, 20], 12) == 10);
        Console.WriteLine(FindHighestNumberBelowTarget([10, 20, 30], 10) == null);
        Console.WriteLine(FindHighestNumberBelowTarget([3, 8, 2], 9) == 8);
        Console.WriteLine(FindHighestNumberBelowTarget([], 9) == null);

        // Mask Code Except Last Three
        // Console.WriteLine(MaskCodeExceptLastThree("ABCDEFG") == "****EFG");
        // Console.WriteLine(MaskCodeExceptLastThree("123456") == "***456");
        // Console.WriteLine(MaskCodeExceptLastThree("ABC") == "ABC");
        // Console.WriteLine(MaskCodeExceptLastThree("AB") == "AB");
        // Console.WriteLine(MaskCodeExceptLastThree(null!) == "");
        // Console.WriteLine(MaskCodeExceptLastThree("") == "");


        // Count Valid Prices
        // Console.WriteLine(CountValidPrices("10, 20, 0, -5, hello") == 2);
        // Console.WriteLine(CountValidPrices("0, -1, abc") == 0);
        // Console.WriteLine(CountValidPrices(" 5, 15 , test, 25 ")== 3);
        // Console.WriteLine(CountValidPrices("")== 0);
        // Console.WriteLine(CountValidPrices(null!)== 0);

        //JsonDataSanitizerRunner.Run();
    }

}
