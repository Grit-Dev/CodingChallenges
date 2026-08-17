using System.Diagnostics.Metrics;

public class Program
{

    public static int FindLongestConsecutiveRun_One(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int sequenceCounter = 1;
        int highestCounter = 1;
        int previousIndexValue = numbers[0];

        for (int outterIndex = 1; outterIndex <= numbers.Length - 1; outterIndex++)
        {
            int indexCurrently = numbers[outterIndex];

            if (previousIndexValue != indexCurrently)
            {
                previousIndexValue = indexCurrently;
                sequenceCounter = 1;
                continue;
            }

            if (previousIndexValue == indexCurrently)
            {
                sequenceCounter++;
            }

            if (sequenceCounter > highestCounter)
            {
                highestCounter = sequenceCounter;
            }

            previousIndexValue = indexCurrently;
        }

        return highestCounter;
    }
    public static void Main(string[] args)
    {
        // Find Longest Consecutive Run
        Console.WriteLine(FindLongestConsecutiveRun_One([1, 1, 2, 2, 2, 3]));
        Console.WriteLine(FindLongestConsecutiveRun_One([5, 5, 5, 5]) == 4);
        Console.WriteLine(FindLongestConsecutiveRun_One([1, 2, 3, 4]) == 1);
        Console.WriteLine(FindLongestConsecutiveRun_One([7]) == 1);
        Console.WriteLine(FindLongestConsecutiveRun_One([1, 1, 2, 1, 1, 1]) == 3);
        Console.WriteLine(FindLongestConsecutiveRun_One(null!) == 0);
        Console.WriteLine(FindLongestConsecutiveRun_One([]) == 0);

        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
