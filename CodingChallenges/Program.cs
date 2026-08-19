
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
    public static void Main(string[] args)
    {
        // Count Valid Usernames 
        Console.WriteLine(CountValidUsernames("paul16, bob, Alice99, bad user") == 2);
        Console.WriteLine(CountValidUsernames("1admin, charlie, DeltaForce") == 2);
        Console.WriteLine(CountValidUsernames("tom, validUser, waytoolongusername") == 1);
        Console.WriteLine(CountValidUsernames("") == 0);
        Console.WriteLine(CountValidUsernames(" ") == 0);
        Console.WriteLine(CountValidUsernames(null!) == 0);


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
