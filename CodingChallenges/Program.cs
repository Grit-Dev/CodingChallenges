using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;

public class Program
{
    public static int CountPositiveEvenNumbers_RV_One(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int total = 0;

        foreach (int value in numbers)
        {
            if (value > 0 && value % 2 == 0)
            {
                total++;
            }
        }

        return total;
    }

    public static int? FindSmallestPositiveNumber_Rev_One(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return null;
        }

        int smallestNumberComparator = int.MaxValue;
        int counter = 0;

        foreach (int digit in numbers)
        {
            if (digit > 0)
            {
                if (digit < smallestNumberComparator)
                {
                    smallestNumberComparator = digit;
                }
            }
            else
            {
                counter++;
            }
        }

        if (counter == numbers.Length)
        {
            return null;
        }

        return smallestNumberComparator;
    }

    public static int CountWordsStartingAndEndingWithSameLetter(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string [] splitString = input.Split([' '], StringSplitOptions.RemoveEmptyEntries);

        foreach(string str in splitString)
        {
            string strTrimmed = str.Trim().ToLower();

            if(strTrimmed.Length == 1)
            {
                counter++;
                continue;
            }

            if(strTrimmed[0] == strTrimmed[strTrimmed.Length -1])
            {
                counter++;
            }
        }

        return counter; 
    }
    public static void Main(string[] args)
    {
        // Count Words Starting And Ending With Same Letter
        // Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("level test radar apple") == 3);
        // Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("Anna went to area") == 2);
        // Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("a I bob cat") == 3);
        // Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("") == 0);
        // Console.WriteLine(CountWordsStartingAndEndingWithSameLetter(" ") == 0);
        // Console.WriteLine(CountWordsStartingAndEndingWithSameLetter(null!) == 0);

        // Find Smallest Positive Number 
        // Console.WriteLine(FindSmallestPositiveNumber_Rev_One([5, 3, 9, 1]) == 1);
        // Console.WriteLine(FindSmallestPositiveNumber_Rev_One([-5, 0, 10, 2]) == 2);
        // Console.WriteLine(FindSmallestPositiveNumber_Rev_One([-1, -2, 0]) == null);
        // Console.WriteLine(FindSmallestPositiveNumber_Rev_One([7]) == 7);
        // Console.WriteLine(FindSmallestPositiveNumber_Rev_One(null!) == null);
        // Console.WriteLine(FindSmallestPositiveNumber_Rev_One([]) == null);

        // Warm Up: Count Positive Numbers
        // Console.WriteLine(CountPositiveEvenNumbers_RV_One([1, 2, 3, 4, -6, 0]) == 2);
        // Console.WriteLine(CountPositiveEvenNumbers_RV_One([2, 4, 6]) == 3);
        // Console.WriteLine(CountPositiveEvenNumbers_RV_One([-2, 0, 1, 3]) == 0);
        // Console.WriteLine(CountPositiveEvenNumbers_RV_One(null!) == 0);
        // Console.WriteLine(CountPositiveEvenNumbers_RV_One([]) == 0);

        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
