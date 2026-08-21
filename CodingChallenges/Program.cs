public class Program
{
    public static int CountPositiveMultiplesOfThree(int[] numbers)
    {
        if(numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach(int digit in numbers)
        {
            if(digit > 0 && digit % 3 == 0)
            {
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Count Positive Multiples of 3
        Console.WriteLine(CountPositiveMultiplesOfThree([3, 6, -3, 10, 12]) == 3);
        Console.WriteLine(CountPositiveMultiplesOfThree([1, 2, 4, 5]) == 0);
        Console.WriteLine(CountPositiveMultiplesOfThree([0, 3, 9]) == 2);
        Console.WriteLine(CountPositiveMultiplesOfThree(null!) == 0);
        Console.WriteLine(CountPositiveMultiplesOfThree([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
