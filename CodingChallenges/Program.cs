
public class Program
{
    public static int CountSignChanges(int[] numbers)
    {
        if (numbers is null || numbers.Length < 2)
        {
            return 0;
        }

        int counter = 0;

        for (int index = 0; index < numbers.Length - 1; index++)
        {
            int currentNumber = numbers[index];
            int nextNumber = numbers[index + 1];

            if (currentNumber == 0 || nextNumber == 0)
            {
                continue;
            }

            if (currentNumber > 0 && nextNumber < 0)
            {
                counter++;
            }
            else if (currentNumber < 0 && nextNumber > 0)
            {
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Count Sign Changes
        Console.WriteLine(CountSignChanges([-1, 2, -3, 0, 4, -5]));
        Console.WriteLine(CountSignChanges([1, 2, 3]) == 0);
        Console.WriteLine(CountSignChanges([-1, -2, 3]) == 1);
        Console.WriteLine(CountSignChanges([0, -1, 1, 0, -2]) == 1);
        Console.WriteLine(CountSignChanges([7]) == 0);
        Console.WriteLine(CountSignChanges(null!) == 0);
        Console.WriteLine(CountSignChanges([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
