public class Program
{
    public static int CountAdjacentIncreases(int[] numbers)
    {
        if (numbers is null || numbers.Length < 2)
        {
            return 0;
        }

        int counter = 0;

        for (int index = 1; index <= numbers.Length -1; index++)
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
        // Warm up: Count Adjacent Increases. 
        Console.WriteLine(CountAdjacentIncreases([1, 3, 2, 5]) == 2);
        Console.WriteLine(CountAdjacentIncreases([5, 4, 3]) == 0);
        Console.WriteLine(CountAdjacentIncreases([1, 2, 3, 4]) == 3);
        Console.WriteLine(CountAdjacentIncreases([7]) == 0);
        Console.WriteLine(CountAdjacentIncreases(null!) == 0);
        Console.WriteLine(CountAdjacentIncreases([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
