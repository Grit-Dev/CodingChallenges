public class Program
{
    public static int CountNumbersBetweenTenAndTwenty(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int count = 0;

        foreach (int digit in numbers)
        {
            if (digit >= 10 && digit <= 20)
            {
                count++;
            }
        }

        return count;
    }

    public static void Main(string[] args)
    {
        // Count Numbers Between 10 and 20
        Console.WriteLine(CountNumbersBetweenTenAndTwenty([5, 10, 15, 20, 25]) == 3);
        Console.WriteLine(CountNumbersBetweenTenAndTwenty([1, 2, 3]) == 0);
        Console.WriteLine(CountNumbersBetweenTenAndTwenty([10, 20, 30]) == 2);
        Console.WriteLine(CountNumbersBetweenTenAndTwenty(null!) == 0);
        Console.WriteLine(CountNumbersBetweenTenAndTwenty([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
