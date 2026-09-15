public class Program
{
    public static int CountNumbersDivisibleByTwoButNotThree(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int number in numbers)
        {
            if (number != 0 && number % 2 == 0 && number % 3 != 0)
            {
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Count Numbers Divisible By Two But Not Three
        Console.WriteLine(CountNumbersDivisibleByTwoButNotThree([2, 3, 4, 6, 8, 9, 12]) == 3);
        Console.WriteLine(CountNumbersDivisibleByTwoButNotThree([6, 12, 18]) == 0);
        Console.WriteLine(CountNumbersDivisibleByTwoButNotThree([0, 2, 4]) == 2);
        Console.WriteLine(CountNumbersDivisibleByTwoButNotThree([1, 3, 5]) == 0);
        Console.WriteLine(CountNumbersDivisibleByTwoButNotThree(null!) == 0);
        Console.WriteLine(CountNumbersDivisibleByTwoButNotThree([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
