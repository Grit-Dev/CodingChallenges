using Xunit.Sdk;

public class Program
{
    public static int CountNegativeMultiplesOfThreeWarmUp(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            if (digit < 0 && digit % 3 == 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static int CountValidCaseCodes(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string[] splitString = input.Split([','], StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim();

            if (strTrimmed.Length == 9 &&
            strTrimmed.StartsWith("CASE-", StringComparison.OrdinalIgnoreCase) &&
            int.TryParse(strTrimmed.Substring(5), out _))
            {
                counter++;
            }
        }

        return counter;
    }

    public static int FindLongestAlternatingEvenOddStreak(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int highestStreakSoFar = 1;
        int streakCounter = 0;
        bool isEven = false;
        bool isOdd = false;

        for (int outerIndex = 0; outerIndex <= numbers.Length - 1; outerIndex++)
        {
            if (numbers[outerIndex] % 2 != 0 && !isOdd)
            {
                streakCounter++;
                isOdd = true;
                isEven = false;
            }
            else if (numbers[outerIndex] % 2 == 0 && !isEven)
            {
                streakCounter++;
                isEven = true;
                isOdd = false;
            }
            else
            {
                streakCounter = 1;

                isEven = numbers[outerIndex] % 2 == 0;
                isOdd = numbers[outerIndex] % 2 != 0;
            }

            if (streakCounter > highestStreakSoFar)
            {
                highestStreakSoFar = streakCounter;
            }
        }

        return highestStreakSoFar;
    }

    public static string FindLongestWordStartingWithLetter(string input, char startingLetter)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        int longestWordCounter = 0;
        string longestWord = "";

        string[] stringSplit = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in stringSplit)
        {
            if (char.ToLower(str[0]) == char.ToLower(startingLetter))
            {
                if (str.Length > longestWordCounter)
                {
                    longestWordCounter = str.Length;
                    longestWord = str;
                }
            }
        }

        return longestWord;

    }

    public static void Main(string[] args)
    {
        // Find Longest Word Starting With Letter
        Console.WriteLine(FindLongestWordStartingWithLetter("apple banana apricot avocado", 'a') == "apricot");
        Console.WriteLine(FindLongestWordStartingWithLetter("Dog duck dinosaur cat", 'd') == "dinosaur");
        Console.WriteLine(FindLongestWordStartingWithLetter("red blue green", 'z') == "");
        Console.WriteLine(FindLongestWordStartingWithLetter("", 'a') == "");
        Console.WriteLine(FindLongestWordStartingWithLetter(" ", 'a') == "");
        Console.WriteLine(FindLongestWordStartingWithLetter(null!, 'a') == "");

        // Find Longest Alternating Even Odd Streak
        // Console.WriteLine(FindLongestAlternatingEvenOddStreak([2, 5, 8, 11, 12, 14]) == 5);
        // Console.WriteLine(FindLongestAlternatingEvenOddStreak([1, 3, 5, 7]) == 1);
        // Console.WriteLine(FindLongestAlternatingEvenOddStreak([2, 4, 6]) == 1);
        // Console.WriteLine(FindLongestAlternatingEvenOddStreak([1, 2, 3, 4]) == 4);
        // Console.WriteLine(FindLongestAlternatingEvenOddStreak([7]) == 1);
        // Console.WriteLine(FindLongestAlternatingEvenOddStreak(null!) == 0);
        // Console.WriteLine(FindLongestAlternatingEvenOddStreak([]) == 0);

        // Count Valid Case Codes
        // Console.WriteLine(CountValidCaseCodes("CASE-1234, CASE-9999, BAD-1234") == 2);
        // Console.WriteLine(CountValidCaseCodes("case-0001, CASE-12A4, CASE-12345") == 1);
        // Console.WriteLine(CountValidCaseCodes("hello, CASE-7777") == 1);
        // Console.WriteLine(CountValidCaseCodes("") == 0);
        // Console.WriteLine(CountValidCaseCodes(" ") == 0);
        // Console.WriteLine(CountValidCaseCodes(null!) == 0);

        // Count Negative Multiples Of Three
        // Console.WriteLine(CountNegativeMultiplesOfThreeWarmUp([-3, -6, 3, 9, -10]) == 2);
        // Console.WriteLine(CountNegativeMultiplesOfThreeWarmUp([-1, -2, -4]) == 0);
        // Console.WriteLine(CountNegativeMultiplesOfThreeWarmUp([-9, 0, -12]) == 2);
        // Console.WriteLine(CountNegativeMultiplesOfThreeWarmUp(null!) == 0);
        // Console.WriteLine(CountNegativeMultiplesOfThreeWarmUp([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
