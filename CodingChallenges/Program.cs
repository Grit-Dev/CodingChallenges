public class Program
{
    public static int CountPositiveNumbersWarmUp(int[] numbers)
    {
        if(numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach(int digit in numbers)
        {
            if(digit > 0 && digit % 2 != 0)
            {
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Warm up: Count Positive Odd Numbers
        Console.WriteLine(CountPositiveNumbersWarmUp([1, 2, 3, -5, 7]) == 3);
        Console.WriteLine(CountPositiveNumbersWarmUp([-1, -3, 2, 4]) == 0);
        Console.WriteLine(CountPositiveNumbersWarmUp([9, 11, 12]) == 2);
        Console.WriteLine(CountPositiveNumbersWarmUp(null!) == 0);
        Console.WriteLine(CountPositiveNumbersWarmUp([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
