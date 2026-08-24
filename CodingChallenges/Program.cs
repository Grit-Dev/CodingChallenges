using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;

public class Program
{
    public static int CountNumbersEndingInFive(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            string digitToString = digit.ToString();

            if (digitToString.EndsWith('5'))
            {
                counter++;
            }
        }

        return counter;
    }

    public static int CountValidEmployeeCodes(string input)
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

            if (strTrimmed.Length == 8 &&
            strTrimmed.StartsWith("EMP-", StringComparison.OrdinalIgnoreCase))
            {
                string lastEndOfString = strTrimmed[4..];

                if (int.TryParse(lastEndOfString, out int _))
                {
                    counter++;
                }
            }
        }

        return counter;
    }

    public static int FindLongestSameWordStreak(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 1;
        int highestStreak = 1;
        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        string previousValue = splitString[0].Trim();

        for (int outerIndex = 1; outerIndex <= splitString.Length - 1; outerIndex++)
        {
            string strTrimmed = splitString[outerIndex];

            if (strTrimmed.Equals(previousValue, StringComparison.OrdinalIgnoreCase))
            {
                counter++;
            }
            else
            {
                counter = 1;
            }

            if (counter > highestStreak)
            {
                highestStreak = counter;
            }

            previousValue = strTrimmed;
        }

        return highestStreak;
    }
    public static int? FindFirstNumberWithPreviousDuplicate(int[] numbers)
    {
        if(numbers is null || numbers.Length == 0)
        {
            return null;
        }    

        List<int> newList = [];

        for(int outerIndex = 0; outerIndex <= numbers.Length -1; outerIndex++)
        {
            if(newList.Contains(numbers[outerIndex]))
            {
                return numbers[outerIndex];
            }
            else
            {
                newList.Add(numbers[outerIndex]);
            }
        }

        return null;
    }

    public static void Main(string[] args)
    {
        // Find First Number With Previous Duplicate
        Console.WriteLine(FindFirstNumberWithPreviousDuplicate([4, 7, 2, 7, 4 ]) == 7);
        Console.WriteLine(FindFirstNumberWithPreviousDuplicate([1, 2, 3, 1 ]) == 1);
        Console.WriteLine(FindFirstNumberWithPreviousDuplicate([5, 6, 7]) == null);
        Console.WriteLine(FindFirstNumberWithPreviousDuplicate([9, 9, 1]) == 9);
        Console.WriteLine(FindFirstNumberWithPreviousDuplicate(null!) == null);
        Console.WriteLine(FindFirstNumberWithPreviousDuplicate([]) == null);

        // Find Longest Same Word Streak
        // Console.WriteLine(FindLongestSameWordStreak("red red blue blue blue red") == 3);
        // Console.WriteLine(FindLongestSameWordStreak("cat cat cat") == 3);
        // Console.WriteLine(FindLongestSameWordStreak("one two three") == 1);
        // Console.WriteLine(FindLongestSameWordStreak("Dog dog DOG cat") == 3);
        // Console.WriteLine(FindLongestSameWordStreak("") == 0);
        // Console.WriteLine(FindLongestSameWordStreak(" ") == 0);
        // Console.WriteLine(FindLongestSameWordStreak(null!) == 0);

        //Count Valid Employee Codes = String Parsing
        // Console.WriteLine(CountValidEmployeeCodes("EMP-1234, EMP-9999, BAD-1234") == 2);
        // Console.WriteLine(CountValidEmployeeCodes("emp-0001, EMP-12A4, EMP-12345") == 1);
        // Console.WriteLine(CountValidEmployeeCodes("hello, EMP-7777") == 1);
        // Console.WriteLine(CountValidEmployeeCodes("") == 0);
        // Console.WriteLine(CountValidEmployeeCodes(" ") == 0);
        // Console.WriteLine(CountValidEmployeeCodes(null!) == 0);

        // Count Numbers Ending in Five
        // Console.WriteLine(CountNumbersEndingInFive([5, 15, 20, -25, 100 ]) == 3);
        // Console.WriteLine(CountNumbersEndingInFive([ 1, 2, 3, 4 ]) == 0);
        // Console.WriteLine(CountNumbersEndingInFive([105, 205, 305 ]) == 3);
        // Console.WriteLine(CountNumbersEndingInFive(null!) == 0);
        // Console.WriteLine(CountNumbersEndingInFive([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
