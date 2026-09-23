
public class Program
{
    public static int CountValuesMatchingIndexSignRule(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        for (int index = 0; index <= numbers.Length - 1; index++)
        {
            if (index % 2 == 0 && numbers[index] > 0)
            {
                counter++;
            }
            else if (index % 2 != 0 && numbers[index] < 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static void Main(string[] args)
    {
        // Count Values Matchying Index Sign Rule
        Console.WriteLine(CountValuesMatchingIndexSignRule([5, -1, 3, 4, -2]) == 3);
        Console.WriteLine(CountValuesMatchingIndexSignRule([1, 2, 3, 4]) == 2);
        Console.WriteLine(CountValuesMatchingIndexSignRule([-1, -2, -3, -4]) == 2);
        Console.WriteLine(CountValuesMatchingIndexSignRule([0, -1, 0, -5]) == 2);
        Console.WriteLine(CountValuesMatchingIndexSignRule(null!) == 0);
        Console.WriteLine(CountValuesMatchingIndexSignRule([]) == 0);


        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
