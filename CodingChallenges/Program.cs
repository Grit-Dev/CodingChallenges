public class Program
{
    public static int CountNumbersGreaterThanPreviousNumber(int[] numbers)
    {
        if (numbers is null || numbers.Length < 2)
        {
            return 0;
        }

        int counter = 0;

        for (int index = 1; index <= numbers.Length - 1; index++)
        {
            if (numbers[index] > numbers[index - 1])
            {
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Count Numbers Greater Than Previous number
        Console.WriteLine(CountNumbersGreaterThanPreviousNumber([1, 3, 2, 5]) == 2);
        Console.WriteLine(CountNumbersGreaterThanPreviousNumber([5, 4, 3]) == 0);
        Console.WriteLine(CountNumbersGreaterThanPreviousNumber([1, 2, 3, 4]) == 3);
        Console.WriteLine(CountNumbersGreaterThanPreviousNumber([7]) == 0);
        Console.WriteLine(CountNumbersGreaterThanPreviousNumber(null!) == 0);
        Console.WriteLine(CountNumbersGreaterThanPreviousNumber([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
