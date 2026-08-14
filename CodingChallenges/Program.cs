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

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - 1])
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
        // Find Longest Plateau
        Console.WriteLine(FindLongestPlateau([1, 1, 2, 2, 2, 3]) == 3);
        Console.WriteLine(FindLongestPlateau([5, 5, 5, 5]) == 4);
        Console.WriteLine(FindLongestPlateau([1, 2, 3, 4]) == 1);
        Console.WriteLine(FindLongestPlateau([7]) == 1);
        Console.WriteLine(FindLongestPlateau(null!) == 0);
        Console.WriteLine(FindLongestPlateau([]) == 0);

        // Find closest Number To Zero Revision
        // Console.WriteLine(FindClosestNumberToZero_Revision([-5, -2, 3, 2]) == 2);
        // Console.WriteLine(FindClosestNumberToZero_Revision([-10, -4, -2]) == -2);
        // Console.WriteLine(FindClosestNumberToZero_Revision([8, -8]) == 8);
        // Console.WriteLine(FindClosestNumberToZero_Revision([0, 5, -1]) == 0);
        // Console.WriteLine(FindClosestNumberToZero_Revision(null!) == null);
        // Console.WriteLine(FindClosestNumberToZero_Revision([]) == null);

        // Count Strong Passwords Revision
        // Console.WriteLine(CountStrongPasswords_Revision("Password1, hello, TEST1234, GoodPass9") == 2);
        // Console.WriteLine(CountStrongPasswords_Revision("abc, 12345678, NoDigitsHere") == 0);
        // Console.WriteLine(CountStrongPasswords_Revision("Aa123456") == 1);
        // Console.WriteLine(CountStrongPasswords_Revision("") == 0);
        // Console.WriteLine(CountStrongPasswords_Revision(" ") == 0);
        // Console.WriteLine(CountStrongPasswords_Revision(null!) == 0);

        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
