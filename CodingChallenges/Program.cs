
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
    public static void Main(string[] args)
    {
        //Count Negative Odd Numbers
        Console.WriteLine(CountNegativeOddNumbers([-1, -2, -3, 4, 5]) == 2);
        Console.WriteLine(CountNegativeOddNumbers([-10, -11, -13]) == 2);
        Console.WriteLine(CountNegativeOddNumbers([1, 3, 5]) == 0);
        Console.WriteLine(CountNegativeOddNumbers(null!) == 0);
        Console.WriteLine(CountNegativeOddNumbers([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
