
using CodingChallenges.Challenges.Phase_02_OOP.Task_Tracker_Basics;

public class Program
{
    public static int CountNegativeOddNumbers(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            if (digit < 0 && digit % 2 != 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static int CountValidUsernames(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string[] stringSplit = input.Split([','], StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in stringSplit)
        {
            string strTrimmed = str.Trim();

            if (strTrimmed.Length >= 5 && strTrimmed.Length <= 12 &&
            char.IsLetter(strTrimmed[0]) && !strTrimmed.Contains(' '))
            {
                counter++;
            }
        }

        return counter;
    }

    public static int FindLongestIncreasingRun(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int currentRun = 1;
        int longestRun = 1;

        for (int outterIndex = 1; outterIndex <= numbers.Length - 1; outterIndex++)
        {
            if (numbers[outterIndex] > numbers[outterIndex - 1])
            {
                currentRun++;

                if (currentRun > longestRun)
                {
                    longestRun = currentRun;
                }
            }
            else
            {
                currentRun = 1;
            }
        }

        return longestRun;
    }

    public static int? FindFirstNumberGreaterThanAllPrevious(int[] numbers)
    {
        if (numbers is null || numbers.Length <= 1)
        {
            return null;
        }

        int maxSoFar = numbers[0];

        for (int outterIndex = 1; outterIndex < numbers.Length; outterIndex++)
        {
            if (numbers[outterIndex] > maxSoFar)
            {
                return numbers[outterIndex];
            }
        }

        return null;
    }
    public static void Main(string[] args)
    {
        // Find First Number Greater Than All Previous
        Console.WriteLine(FindFirstNumberGreaterThanAllPrevious([5, 3, 4, 10, 2]) == 10);
        Console.WriteLine(FindFirstNumberGreaterThanAllPrevious([10, 9, 8, 7]) == null);
        Console.WriteLine(FindFirstNumberGreaterThanAllPrevious([1, 2, 3]) == 2);
        Console.WriteLine(FindFirstNumberGreaterThanAllPrevious([4, 4, 5]) == 5);
        Console.WriteLine(FindFirstNumberGreaterThanAllPrevious([7]) == null);
        Console.WriteLine(FindFirstNumberGreaterThanAllPrevious(null!) == null);
        Console.WriteLine(FindFirstNumberGreaterThanAllPrevious([]) == null);

        // Find Longest Increasing Run
        // Console.WriteLine(FindLongestIncreasingRun([1, 2, 3, 1, 2]) == 3);
        // Console.WriteLine(FindLongestIncreasingRun([5, 4, 3, 2]) == 1);
        // Console.WriteLine(FindLongestIncreasingRun([1, 3, 5, 7]) == 4);
        // Console.WriteLine(FindLongestIncreasingRun([2, 2, 3, 4]) == 3);
        // Console.WriteLine(FindLongestIncreasingRun([7]) == 1);
        // Console.WriteLine(FindLongestIncreasingRun(null!) == 0);
        // Console.WriteLine(FindLongestIncreasingRun([]) == 0);

        // Count Valid Usernames 
        // Console.WriteLine(CountValidUsernames("paul16, bob, Alice99, bad user") == 2);
        // Console.WriteLine(CountValidUsernames("1admin, charlie, DeltaForce") == 2);
        // Console.WriteLine(CountValidUsernames("tom, validUser, waytoolongusername") == 1);
        // Console.WriteLine(CountValidUsernames("") == 0);
        // Console.WriteLine(CountValidUsernames(" ") == 0);
        // Console.WriteLine(CountValidUsernames(null!) == 0);

        //Count Negative Odd Numbers
        // Console.WriteLine(CountNegativeOddNumbers([-1, -2, -3, 4, 5]) == 2);
        // Console.WriteLine(CountNegativeOddNumbers([-10, -11, -13]) == 2);
        // Console.WriteLine(CountNegativeOddNumbers([1, 3, 5]) == 0);
        // Console.WriteLine(CountNegativeOddNumbers(null!) == 0);
        // Console.WriteLine(CountNegativeOddNumbers([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
