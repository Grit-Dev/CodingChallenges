public class Program
{
    public static int CountNumbersDivisibleByTwoOrThreeButNotBoth(int[] numbers)
    {
        if(numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach(int number in numbers)
        {
            if(number % 2 == 0 && number % 3 == 0)
            {
                continue;
            }
            else if(number % 2 == 0 || number % 3 == 0 && number != 0)
            {
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Warm up: Count Numbers divisible by two or three but noth Both. 
        Console.WriteLine(CountNumbersDivisibleByTwoOrThreeButNotBoth([2, 3, 4, 6, 9, 12, 15]) == 5);
        Console.WriteLine(CountNumbersDivisibleByTwoOrThreeButNotBoth([6, 12, 18]) == 0);
        Console.WriteLine(CountNumbersDivisibleByTwoOrThreeButNotBoth([2, 4, 8]) == 3);
        Console.WriteLine(CountNumbersDivisibleByTwoOrThreeButNotBoth([3, 9, 15]) == 3);
        Console.WriteLine(CountNumbersDivisibleByTwoOrThreeButNotBoth([0, 2, 6]) == 1);
        Console.WriteLine(CountNumbersDivisibleByTwoOrThreeButNotBoth(null!) == 0);
        Console.WriteLine(CountNumbersDivisibleByTwoOrThreeButNotBoth([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
