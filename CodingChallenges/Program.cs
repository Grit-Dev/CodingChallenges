public class Program
{
    public static int CountNumbersOutsideRange(int[] numbers, int min, int max)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            if (digit < min || digit > max)
            {
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {

        // Warm Up: Count Numbers Outside Range
        Console.WriteLine(CountNumbersOutsideRange([1, 5, 10, 15, 20], 5, 15) == 2);
        Console.WriteLine(CountNumbersOutsideRange([5, 10, 15], 5, 15) == 0);
        Console.WriteLine(CountNumbersOutsideRange([-5, 0, 50], 0, 20) == 2);
        Console.WriteLine(CountNumbersOutsideRange(null!, 0, 10) == 0);
        Console.WriteLine(CountNumbersOutsideRange([], 0, 10) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
