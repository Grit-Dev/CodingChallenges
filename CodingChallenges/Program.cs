public class Program
{
    public static int CountNegativeEvenNumbersWarmUp(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach(int digit in numbers)
        {
            if(digit < 0 && digit % 2 == 0)
            {
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Warm Up: Count Negative Numbers
        Console.WriteLine(CountNegativeEvenNumbersWarmUp([-2, -4, 5, 8, -7]) == 2);
        Console.WriteLine(CountNegativeEvenNumbersWarmUp([-1, -3, -5]) == 0);
        Console.WriteLine(CountNegativeEvenNumbersWarmUp([-10, 0, -12]) == 2);
        Console.WriteLine(CountNegativeEvenNumbersWarmUp(null!) == 0);
        Console.WriteLine(CountNegativeEvenNumbersWarmUp([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
