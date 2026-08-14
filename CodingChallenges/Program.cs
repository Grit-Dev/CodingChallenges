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
    public static void Main(string[] args)
    {
        // Count Strong Passwords Revision
        Console.WriteLine(CountStrongPasswords_Revision("Password1, hello, TEST1234, GoodPass9") == 2);
        Console.WriteLine(CountStrongPasswords_Revision("abc, 12345678, NoDigitsHere") == 0);
        Console.WriteLine(CountStrongPasswords_Revision("Aa123456") == 1);
        Console.WriteLine(CountStrongPasswords_Revision("") == 0);
        Console.WriteLine(CountStrongPasswords_Revision(" ") == 0);
        Console.WriteLine(CountStrongPasswords_Revision(null!) == 0);

        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
