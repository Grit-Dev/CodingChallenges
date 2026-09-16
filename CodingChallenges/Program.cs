public class Program
{
    public static int[] GetTopTwoEvenNumbersWithLinq(int[] numbers) =>
    numbers is null || numbers.Length == 0 ? [] :
    numbers.Where(n => n % 2 == 0).OrderByDescending(n => n).Take(2).ToArray();

    public static string? FindMostExpensiveItem(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return null;
        }

        int? HighestPriceSoFar = null;
        string? highestProductPriceItem = null;

        string[] stringSplit = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in stringSplit)
        {
            string strTrimmed = str.Trim();

            int indexOfEqualCounter = strTrimmed.Count(ioe => ioe == '=');
            int indexOfEqual = strTrimmed.IndexOf('=');

            if (indexOfEqualCounter != 1)
            {
                continue;
            }

            if (strTrimmed.Substring(0, indexOfEqual).Length == 0 ||
            strTrimmed.Substring(indexOfEqual + 1).Length == 0)
            {
                continue;
            }

            if (int.TryParse(strTrimmed.Substring(indexOfEqual + 1), out int value) &&
            value >= 0 && (HighestPriceSoFar is null || value > HighestPriceSoFar))
            {
                HighestPriceSoFar = value;
                highestProductPriceItem = strTrimmed.Substring(0, indexOfEqual).Trim();
            }
        }

        return highestProductPriceItem;
    }

    public static int? FindFirstNumberFollowedByABiggerNumber(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return null;
        }

        int? previousNumber = null;

        foreach (int number in numbers)
        {
            if (previousNumber < number)
            {
                return previousNumber;
            }

            previousNumber = number;
        }

        return previousNumber;
    }

    public static int FindLongestEvenStreak(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int currentStreak = 0;
        int longestStreak = 0;

        foreach (int number in numbers)
        {
            if (int.IsEvenInteger(number))
            {
                currentStreak++;
            }
            else
            {
                currentStreak = 0;
            }

            if (currentStreak > longestStreak)
            {
                longestStreak = currentStreak;
            }
        }

        return longestStreak;
    }

    public static int? FindFirstRepeatedNumber(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return null;
        }

        Dictionary<int, int> newDict = [];

        foreach (int number in numbers)
        {
            if (newDict.TryGetValue(number, out int value))
            {
                newDict[number] = value + 1;

                return number;
            }
            else
            {
                newDict[number] = 1;
            }
        }

        return null;
    }

    public static int? FindFirstPeakNumber(int[] numbers)
    {
        if(numbers is null || numbers.Length < 3)
        {
            return null;
        }

        for(int index = 1; index < numbers.Length -1; index++)
        {
            if(numbers[index -1] < numbers[index] && 
            numbers[index +1] < numbers[index])
            {
                return numbers[index];
            }
        }

        return null;
    }
    public static void Main(string[] args)
    {
        // Find the First Peak Number
        Console.WriteLine(FindFirstPeakNumber([1, 5, 2]) == 5);
        Console.WriteLine(FindFirstPeakNumber([1, 2, 3, 2]) == 3);
        Console.WriteLine(FindFirstPeakNumber([5, 4, 3, 2]) == null);
        Console.WriteLine(FindFirstPeakNumber([1, 3, 2, 5, 1]) == 3);
        Console.WriteLine(FindFirstPeakNumber([1, 2]) == null);
        Console.WriteLine(FindFirstPeakNumber(null!) == null);

        // Find The First Repeated Number
        // Console.WriteLine(FindFirstRepeatedNumber([5, 2, 8, 2, 7]) == 2);
        // Console.WriteLine(FindFirstRepeatedNumber([1, 1, 2, 2]) == 1);
        // Console.WriteLine(FindFirstRepeatedNumber([3, 4, 5]) == null);
        // Console.WriteLine(FindFirstRepeatedNumber([-1, 5, -1]) == -1);
        // Console.WriteLine(FindFirstRepeatedNumber(null!) == null);
        // Console.WriteLine(FindFirstRepeatedNumber([]) == null);

        // Find Longest Even Streak
        // Console.WriteLine(FindLongestEvenStreak([2, 4, 6, 1, 8, 10]) == 3);
        // Console.WriteLine(FindLongestEvenStreak([1, 3, 5]) == 0);
        // Console.WriteLine(FindLongestEvenStreak([2, 4, 6, 8]) == 4);
        // Console.WriteLine(FindLongestEvenStreak([1, 2, 4, 1, 6, 8, 10]) == 3);
        // Console.WriteLine(FindLongestEvenStreak(null!) == 0);
        // Console.WriteLine(FindLongestEvenStreak([]) == 0);

        // Find First Number Followed By A Bigger Number 
        // Console.WriteLine(FindFirstNumberFollowedByABiggerNumber([5, 2, 7, 1]) == 2);
        // Console.WriteLine(FindFirstNumberFollowedByABiggerNumber([1, 2, 3]) == 1);
        // Console.WriteLine(FindFirstNumberFollowedByABiggerNumber([5, 4, 3]) == null);
        // Console.WriteLine(FindFirstNumberFollowedByABiggerNumber([-5, -1]) == -5);
        // Console.WriteLine(FindFirstNumberFollowedByABiggerNumber(null!) == null);
        // Console.WriteLine(FindFirstNumberFollowedByABiggerNumber([]) == null);

        // Find Most Expensive Item
        // Console.WriteLine(FindMostExpensiveItem("box=50, sleeves=10, binder=40") == "box");
        // Console.WriteLine(FindMostExpensiveItem("box=50, binder=50, sleeves=10") == "box");
        // Console.WriteLine(FindMostExpensiveItem("box=abc, sleeves=-1") == null);
        // Console.WriteLine(FindMostExpensiveItem(" item = 100 , other = 99 ") == "item");
        // Console.WriteLine(FindMostExpensiveItem("bad=10=20, good=5") == "good");
        // Console.WriteLine(FindMostExpensiveItem("") == null);
        // Console.WriteLine(FindMostExpensiveItem(" ") == null);
        // Console.WriteLine(FindMostExpensiveItem(null!) == null);

        // Get Top Two Even Numbers
        // Console.WriteLine(GetTopTwoEvenNumbersWithLinq([1, 8, 4, 10, 3]).SequenceEqual([10, 8]));
        // Console.WriteLine(GetTopTwoEvenNumbersWithLinq([2]).SequenceEqual([2]));
        // Console.WriteLine(GetTopTwoEvenNumbersWithLinq([7, 9]).Length == 0);
        // Console.WriteLine(GetTopTwoEvenNumbersWithLinq(null!).Length == 0);
        // Console.WriteLine(GetTopTwoEvenNumbersWithLinq([]).Length == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
