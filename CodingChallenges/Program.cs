using System.Diagnostics.Metrics;
using System.Numerics;

public class Program
{
    public static int CountPositiveEvenNumbers_RV_One(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int total = 0;

        foreach (int value in numbers)
        {
            if (value > 0 && value % 2 == 0)
            {
                total++;
            }
        }

        return total;
    }
    public static void Main(string[] args)
    {
        // Warm Up: Count Positive Numbers
        Console.WriteLine(CountPositiveEvenNumbers_RV_One([1, 2, 3, 4, -6, 0]) == 2);
        Console.WriteLine(CountPositiveEvenNumbers_RV_One([2, 4, 6]) == 3);
        Console.WriteLine(CountPositiveEvenNumbers_RV_One([-2, 0, 1, 3]) == 0);
        Console.WriteLine(CountPositiveEvenNumbers_RV_One(null!) == 0);
        Console.WriteLine(CountPositiveEvenNumbers_RV_One([]) == 0);

        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
