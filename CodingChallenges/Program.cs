using System.Globalization;

public class Program
{
    public static int? FindFirstGapGreaterThanThree(int[] numbers)
    {
        if (numbers is null || numbers.Length < 2)
        {
            return null;
        }

        const int biggestgapBetweenNumbers = 3;

        for (int index = 1; index <= numbers.Length - 1; index++)
        {
            int total = Math.Abs(numbers[index] - numbers[index - 1]);

            if (total > biggestgapBetweenNumbers)
            {
                return total;
            }
        }

        return null;
    }

    public static int CountDirectionChanges(int[] numbers)
    {
        if (numbers is null || numbers.Length < 3)
        {
            return 0;
        }

        bool isGoingUp = false;
        bool isGoingDown = false;
        int counter = 0;

        for (int index = 1; index <= numbers.Length - 1; index++)
        {
            if (numbers[index - 1] < numbers[index])
            {
                if (isGoingDown)
                {
                    counter++;
                }

                isGoingUp = true;
                isGoingDown = false;
            }
            else if (numbers[index - 1] > numbers[index])
            {
                if (isGoingUp)
                {
                    counter++;
                }

                isGoingDown = true;
                isGoingUp = false;

            }
        }

        return counter;
    }

    public static int? FindFirstNumberSeenThreeTimes(int[] numbers)
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

                if (newDict[number] == 3)
                {
                    return number;
                }
            }
            else
            {
                newDict[number] = 1;
            }
        }
        return null;
    }

    public static int FindLongestDuplicateStreakRev(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;

        }

        int currentStreak = 1;
        int highestStreak = 1;

        for (int index = 1; index < numbers.Length; index++)
        {
            if (numbers[index] == numbers[index - 1])
            {
                currentStreak++;
            }
            else
            {
                currentStreak = 1;
            }

            if (currentStreak > highestStreak)
            {
                highestStreak = currentStreak;
            }
        }

        return highestStreak;
    }

    public static int? FindFirstNumberLargerThanNextTwoCombined(int[] numbers)
    {
        if (numbers is null || numbers.Length < 3)
        {
            return null;
        }

        for (int index = 0; index < numbers.Length - 2; index++)
        {
            if (numbers[index] > numbers[index + 1] + numbers[index + 2])
            {
                return numbers[index];
            }
        }

        return null;
    }

    public static int CountNumbersInsideRangeButNotEdges(int[] numbers, int min, int max)
    {
        if(numbers is null || numbers.Length == 0 || min >= max)
        {
            return 0;
        }

        return numbers.Count(n => n > min && n < max);
    }

    public static void Main(string[] args)
    {

        // Warm Up: Count Numbers Inside Range But Not Equal To Edges
        Console.WriteLine(CountNumbersInsideRangeButNotEdges([1, 5, 10, 15, 20], 5, 20) == 2);
        Console.WriteLine(CountNumbersInsideRangeButNotEdges([5, 6, 7, 8], 5, 8) == 2);
        Console.WriteLine(CountNumbersInsideRangeButNotEdges([1, 2, 3], 3, 3) == 0);
        Console.WriteLine(CountNumbersInsideRangeButNotEdges([1, 2, 3], 10, 5) == 0);
        Console.WriteLine(CountNumbersInsideRangeButNotEdges(null!, 0, 10) == 0);
        Console.WriteLine(CountNumbersInsideRangeButNotEdges([], 0, 10) == 0);

        // Find First Number Larger Than The Next Two Numbers Combined
        // Console.WriteLine(FindFirstNumberLargerThanNextTwoCombined([10, 3, 4]) == 10);
        // Console.WriteLine(FindFirstNumberLargerThanNextTwoCombined([5, 3, 2]) == null);
        // Console.WriteLine(FindFirstNumberLargerThanNextTwoCombined([1, 20, 5, 5, 2]) == 20);
        // Console.WriteLine(FindFirstNumberLargerThanNextTwoCombined([1, 2, 3, 4, 5]) == null);
        // Console.WriteLine(FindFirstNumberLargerThanNextTwoCombined([5, 1, 1, 10, 3, 4]) == 5);
        // Console.WriteLine(FindFirstNumberLargerThanNextTwoCombined([]) == null);
        // Console.WriteLine(FindFirstNumberLargerThanNextTwoCombined(null!) == null);

        // Find Longest Consecutive Duplicate Streak
        // Console.WriteLine(FindLongestDuplicateStreakRev([7, 7, 7, 7]) == 4);
        // Console.WriteLine(FindLongestDuplicateStreakRev([5, 5, 5, 2, 2, 7]) == 3);
        // Console.WriteLine(FindLongestDuplicateStreakRev([1, 2, 3, 4]) == 1);
        // Console.WriteLine(FindLongestDuplicateStreakRev([1, 1, 2, 2, 2, 3]) == 3);
        // Console.WriteLine(FindLongestDuplicateStreakRev([]) == 0);
        // Console.WriteLine(FindLongestDuplicateStreakRev(null!) == 0);

        // Find Firstr Number Seen Three Times
        // Console.WriteLine(FindFirstNumberSeenThreeTimes([5, 2, 5, 7, 5]) == 5);
        // Console.WriteLine(FindFirstNumberSeenThreeTimes([1, 2, 1, 2, 1]) == 1);
        // Console.WriteLine(FindFirstNumberSeenThreeTimes([3, 3, 3]) == 3);
        // Console.WriteLine(FindFirstNumberSeenThreeTimes([1, 2, 3]) == null);
        // Console.WriteLine(FindFirstNumberSeenThreeTimes([]) == null);
        // Console.WriteLine(FindFirstNumberSeenThreeTimes(null!) == null);

        // Count Direction Changes
        // Console.WriteLine(CountDirectionChanges([1, 3, 5, 4, 2, 6]) == 2);
        // Console.WriteLine(CountDirectionChanges([1, 2, 3, 4]) == 0);
        // Console.WriteLine(CountDirectionChanges([4, 3, 2, 1]) == 0);
        // Console.WriteLine(CountDirectionChanges([1, 3, 1, 3, 1]) == 3);
        // Console.WriteLine(CountDirectionChanges([]) == 0);
        // Console.WriteLine(CountDirectionChanges(null!) == 0);

        // Find The First Gap Greater Than Three
        // Console.WriteLine(FindFirstGapGreaterThanThree([5, 6, 10, 11]) == 4);
        // Console.WriteLine(FindFirstGapGreaterThanThree([1, 2, 3, 4]) == null);
        // Console.WriteLine(FindFirstGapGreaterThanThree([10, 5]) == 5);
        // Console.WriteLine(FindFirstGapGreaterThanThree([-1, -8]) == 7);
        // Console.WriteLine(FindFirstGapGreaterThanThree(null!) == null);
        // Console.WriteLine(FindFirstGapGreaterThanThree([]) == null);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
