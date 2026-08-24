public class Program
{
    public static int CountNumbersEndingInFive(int [] numbers)
    {
        if(numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach(int digit in numbers)
        {
            string digitToString = digit.ToString();
            
            if(digitToString.EndsWith('5'))
            {
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Count Numbers Ending in Five
        Console.WriteLine(CountNumbersEndingInFive([5, 15, 20, -25, 100 ]) == 3);
        Console.WriteLine(CountNumbersEndingInFive([ 1, 2, 3, 4 ]) == 0);
        Console.WriteLine(CountNumbersEndingInFive([105, 205, 305 ]) == 3);
        Console.WriteLine(CountNumbersEndingInFive(null!) == 0);
        Console.WriteLine(CountNumbersEndingInFive([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
