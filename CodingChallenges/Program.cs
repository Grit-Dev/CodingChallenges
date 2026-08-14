public class Program
{
    public static int CountStrongPasswords_Revision(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int strongPasswordCounter = 0;
        string[] stringSplit = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in stringSplit)
        {
            int uppcaseCounter = 0;
            int lowercaseCounter = 0;
            int digitCounter = 0;

            string strTrimmed = str.Trim();

            if (strTrimmed.Contains(' '))
            {
                continue;
            }

            if (strTrimmed.Length >= 8)
            {
                foreach (char character in strTrimmed)
                {
                    if (char.IsUpper(character))
                    {
                        uppcaseCounter++;
                    }

                    if (char.IsLower(character))
                    {
                        lowercaseCounter++;
                    }

                    if (char.IsDigit(character))
                    {
                        digitCounter++;
                    }
                }
            }

            if (uppcaseCounter > 0 && lowercaseCounter > 0 && digitCounter > 0)
            {
                strongPasswordCounter++;
            }
        }

        return strongPasswordCounter;
    }

    public static int? FindClosestNumberToZero_Revision(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return null;
        }

        int indexNumberClosestToZero = numbers[0];
        int distanceToZero = Math.Abs(numbers[0]);

        foreach (int digit in numbers)
        {
            int digitProcessed = Math.Abs(digit);

            if (digitProcessed == distanceToZero && digit > indexNumberClosestToZero)
            {
                indexNumberClosestToZero = digit;
            }

            if (digitProcessed < distanceToZero)
            {
                indexNumberClosestToZero = digit;
                distanceToZero = digitProcessed;
            }
        }

        return indexNumberClosestToZero;

    }
    public static int FindLongestPlateau(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int longestPlateau = 1;
        int currentPlateau = 1;

        for (int outterIndex = 1; outterIndex <= numbers.Length -1; outterIndex++)
        {
            if (numbers[outterIndex] == numbers[outterIndex - 1])
            {
                currentPlateau++;
            }
            else
            {
                currentPlateau = 1;
            }

            if (currentPlateau > longestPlateau)
            {
                longestPlateau = currentPlateau;
            }
        }

        return longestPlateau;
    }

    public static void Main(string[] args)
    {
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
