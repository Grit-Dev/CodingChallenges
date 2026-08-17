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

    public static int CountValidOrderReferences(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int validCounter = 0;
        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim();

            if (strTrimmed.Length != 8)
            {
                continue;
            }

            if (!strTrimmed.StartsWith("ORD-", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            if (!strTrimmed.Substring(4).All(char.IsDigit))
            {
                continue;
            }

            validCounter++;
        }

        return validCounter;
    }

    public static int? FindFirstNumberRepeatedExactlyTwice(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return null;
        }

        for (int outerIndex = 0; outerIndex <= numbers.Length -1; outerIndex++)
        {
            int currentNumber = numbers[outerIndex];
            int counter = 0;

            for (int innerIndex = 0; innerIndex <= numbers.Length -1; innerIndex++)
            {
                if (currentNumber == numbers[innerIndex])
                {
                    counter++;
                }
            }

            if (counter == 2)
            {
                return currentNumber;
            }
        }

        return null;
    }
    public static void Main(string[] args)
    {
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
