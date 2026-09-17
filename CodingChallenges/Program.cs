public class Program
{
    public static int CountNumbersGreaterThanPreviousNumber(int[] numbers)
    {
        if (numbers is null || numbers.Length < 2)
        {
            return 0;
        }

        int counter = 0;

        for (int index = 1; index <= numbers.Length - 1; index++)
        {
            if (numbers[index] > numbers[index - 1])
            {
                counter++;
            }
        }

        return counter;
    }

    public static string MaskAllButLastThreeCharacters(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        if (input.Length <= 3)
        {
            return input;
        }

        int charactersToMask = input.Length - 3;

        string startOfString = new string('*', charactersToMask);
        string endOfString = input.Substring(charactersToMask);

        return startOfString + endOfString;
    }

    public static int? FindHighestRunningTotal(int[] numbers)
    {
        if(numbers is null || numbers.Length == 0)
        {
            return null;
        }

        int total = 0;
        int? highestRunningTotal = null;

        foreach(int number in numbers)
        {
            total += number;

            if(highestRunningTotal is null || total > highestRunningTotal)
            {
                highestRunningTotal = total;
            }
        }

        return highestRunningTotal;
    }
    public static void Main(string[] args)
    {
        // Find Highest Running Total
        Console.WriteLine(FindHighestRunningTotal([3, -1, 5, -10]) == 7);
        Console.WriteLine(FindHighestRunningTotal([5, -2, -10, 20]) == 13);
        Console.WriteLine(FindHighestRunningTotal([-2, -3, -1]) == -2);
        Console.WriteLine(FindHighestRunningTotal([1, 1, -5]) == 2);
        Console.WriteLine(FindHighestRunningTotal(null!) == null);
        Console.WriteLine(FindHighestRunningTotal([]) == null);

        // Mask All But Last Three Characters 
        // Console.WriteLine(MaskAllButLastThreeCharacters("abcdef") == "***def");
        // Console.WriteLine(MaskAllButLastThreeCharacters("Paul") == "*aul");
        // Console.WriteLine(MaskAllButLastThreeCharacters("abc") == "abc");
        // Console.WriteLine(MaskAllButLastThreeCharacters("a") == "a");
        // Console.WriteLine(MaskAllButLastThreeCharacters("") == "");
        // Console.WriteLine(MaskAllButLastThreeCharacters("   ") == "");
        // Console.WriteLine(MaskAllButLastThreeCharacters(null!) == "");

        // Count Numbers Greater Than Previous number
        // Console.WriteLine(CountNumbersGreaterThanPreviousNumber([1, 3, 2, 5]) == 2);
        // Console.WriteLine(CountNumbersGreaterThanPreviousNumber([5, 4, 3]) == 0);
        // Console.WriteLine(CountNumbersGreaterThanPreviousNumber([1, 2, 3, 4]) == 3);
        // Console.WriteLine(CountNumbersGreaterThanPreviousNumber([7]) == 0);
        // Console.WriteLine(CountNumbersGreaterThanPreviousNumber(null!) == 0);
        // Console.WriteLine(CountNumbersGreaterThanPreviousNumber([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
