
public class Program
{

    public static double CalculateAverageOfPositiveNumbers(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;
        int total = 0;

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                total += number;
                counter++;
            }
        }

        if (counter == 0)
        {
            return 0;
        }
        return (double)total / counter;
    }

    public static string CreateInitials(string fullName)
    {
        if(string.IsNullOrWhiteSpace(fullName))
        {
            return "";
        }

        string initials = "";

        string[] splitString = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach(string str in splitString)
        {

            initials += char.ToUpper(str[0]);
        }

        return initials;

    }
    public static void Main(string[] args)
    {
        // Create Initials 
        Console.WriteLine(CreateInitials("Paul mcKinley") == "PM");
        Console.WriteLine(CreateInitials("john michael smith") == "JMS");
        Console.WriteLine(CreateInitials(" sarah connor ") == "SC");
        Console.WriteLine(CreateInitials("A") == "A");
        Console.WriteLine(CreateInitials("") == "");
        Console.WriteLine(CreateInitials(" ") == "");
        Console.WriteLine(CreateInitials(null!) == "");

        // Calculate Average Of Positive Numbers 
        // Console.WriteLine(CalculateAverageOfPositiveNumbers([2, 4, -1, 0, 6]) == 4);
        // Console.WriteLine(CalculateAverageOfPositiveNumbers([-1, -2, 0]) == 0);
        // Console.WriteLine(CalculateAverageOfPositiveNumbers([10]) == 10);
        // Console.WriteLine(CalculateAverageOfPositiveNumbers(null!) == 0);
        // Console.WriteLine(CalculateAverageOfPositiveNumbers([]) == 0);
        // Console.WriteLine(CalculateAverageOfPositiveNumbers([1, 2]) == 1.5);


        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
