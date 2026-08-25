public class Program
{
    public static int CountOddNumbersAtOddIndexes(int [] numbers)
    {
        if(numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        for(int outerIndex = 1; outerIndex <= numbers.Length -1; outerIndex += 2)
        {
            if(numbers[outerIndex] % 2 != 0)
            {
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Count Odd Numbers At Odd Indexes
        Console.WriteLine(CountOddNumbersAtOddIndexes([10, 3, 8, 7, 6]) == 2);
        Console.WriteLine(CountOddNumbersAtOddIndexes([1, 2, 3, 4]) == 0);
        Console.WriteLine(CountOddNumbersAtOddIndexes([5, 9, 2, 11]) == 2);
        Console.WriteLine(CountOddNumbersAtOddIndexes(null!) == 0);
        Console.WriteLine(CountOddNumbersAtOddIndexes([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
