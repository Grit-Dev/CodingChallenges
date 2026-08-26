public class Program
{
    public static int CountPositiveMultiplesOfFive(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            if (digit > 0 && digit % 5 == 0)
            {
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Warm Up: Count Positive Multiples of Five
        Console.WriteLine(CountPositiveMultiplesOfFive([5, 10, -5, 12, 25]) == 3);
        Console.WriteLine(CountPositiveMultiplesOfFive([1, 2, 3, 4]) == 0);
        Console.WriteLine(CountPositiveMultiplesOfFive([0, 5, 15]) == 2);
        Console.WriteLine(CountPositiveMultiplesOfFive(null!) == 0);
        Console.WriteLine(CountPositiveMultiplesOfFive([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
