public class Program
{
    public static int CountNegativeMultiplesOfThreeWarmUp(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach(int digit in numbers)
        {
            if( digit < 0 && digit % 3 == 0)
            {
                counter++;        
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Count Negative Multiples Of Three
        Console.WriteLine(CountNegativeMultiplesOfThreeWarmUp([-3, -6, 3, 9, -10]) == 2);
        Console.WriteLine(CountNegativeMultiplesOfThreeWarmUp([-1, -2, -4]) == 0);
        Console.WriteLine(CountNegativeMultiplesOfThreeWarmUp([-9, 0, -12]) == 2);
        Console.WriteLine(CountNegativeMultiplesOfThreeWarmUp(null!) == 0);
        Console.WriteLine(CountNegativeMultiplesOfThreeWarmUp([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
