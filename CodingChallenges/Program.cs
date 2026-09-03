
public class Program
{
    public static int CountNumbersDivisibleByThreeOrFive(int[] numbers)
    {
        if(numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach(int digit in numbers)
        {
            if(digit == 0)
            {
                continue;
            }

            if((digit % 3 == 0 && digit % 5 == 0) || 
            digit % 3 == 0 || digit % 5 == 0)
            {
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Warm Up: Count Numbers Divisible By Three Or Five
        Console.WriteLine(CountNumbersDivisibleByThreeOrFive([3, 5, 15, 7, 10]) == 4);
        Console.WriteLine(CountNumbersDivisibleByThreeOrFive([1, 2, 4, 8]) == 0);
        Console.WriteLine(CountNumbersDivisibleByThreeOrFive([0, 30, -5]) == 2);
        Console.WriteLine(CountNumbersDivisibleByThreeOrFive(null!) == 0);
        Console.WriteLine(CountNumbersDivisibleByThreeOrFive([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
