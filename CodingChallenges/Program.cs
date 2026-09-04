
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
        if (string.IsNullOrWhiteSpace(fullName))
        {
            return "";
        }

        string initials = "";

        string[] splitString = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {

            initials += char.ToUpper(str[0]);
        }

        return initials;

    }

    public static int? FindHighestTotalOfThreeConsecutiveNumbers(int[] numbers)
    {
        if (numbers is null || numbers.Length < 3)
        {
            return null;
        }

        int highestSoFar = numbers[0] + numbers[1] + numbers[2];

        for (int outerIndex = 1; outerIndex < numbers.Length - 1; outerIndex++)
        {
            int total = 0;
            total = numbers[outerIndex] + numbers[outerIndex - 1] + numbers[outerIndex + 1];

            if (total > highestSoFar)
            {
                highestSoFar = total;
            }
        }

        return highestSoFar;
    }

    public static int SumValidOrderTotals(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int total = 0;

        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim();

            if (!strTrimmed.Contains(':'))
            {
                continue;
            }

            string[] parts = strTrimmed.Split(':');

            if (parts.Length != 2)
            {
                continue;
            }

            string orderId = parts[0].Trim();
            string totalText = parts[1].Trim();

            if (string.IsNullOrWhiteSpace(orderId) ||
                string.IsNullOrWhiteSpace(totalText))
            {
                continue;
            }

            if (int.TryParse(totalText, out int value) && value >= 0)
            {
                total += value;
            }
        }

        return total;
    }

    public static Dictionary<string, int> GroupScoresByResult(int[] numbers)
    {
        if(numbers is null || numbers.Length == 0)
        {
            return [];
        }    

        Dictionary<string, int> newDict = [];

        foreach(int number in numbers)
        {
            string result = number >= 50 ? "pass" : "fail";

            if(newDict.TryGetValue(result, out int value))
            {
                newDict[result] = value + 1;
            }
            else
            {
                newDict[result] = 1;
            }
        }

        return newDict;
    }

    public static void Main(string[] args)
    {

        // Group Scores By Result
        Dictionary<string, int> groupedOne = GroupScoresByResult([80, 40, 50, 20]);
        Console.WriteLine(groupedOne["pass"] == 2);
        Console.WriteLine(groupedOne["fail"] == 2);

        Dictionary<string, int> groupedTwo = GroupScoresByResult([90, 100]);
        Console.WriteLine(groupedTwo["pass"] == 2);
        Console.WriteLine(groupedTwo.ContainsKey("fail") == false);

        Dictionary<string, int> groupedThree = GroupScoresByResult(null!);
        Console.WriteLine(groupedThree.Count == 0);

        // Sum Valid Order Totals
        // Console.WriteLine(SumValidOrderTotals("ORD-1:50, ORD-2:25, BAD"));
        // Console.WriteLine(SumValidOrderTotals("ORD-1:10, ORD-2:abc, ORD-3:5") == 15);
        // Console.WriteLine(SumValidOrderTotals("ORD-1:-5, ORD-2:20") == 20);
        // Console.WriteLine(SumValidOrderTotals("BAD, ALSO-BAD") == 0);
        // Console.WriteLine(SumValidOrderTotals("") == 0);
        // Console.WriteLine(SumValidOrderTotals(" ") == 0);
        // Console.WriteLine(SumValidOrderTotals(null!) == 0);

        // Find Highest Total of Three Consecutive Numbers
        // Console.WriteLine(FindHighestTotalOfThreeConsecutiveNumbers([1, 2, 3, 4, 5]) == 12);
        // Console.WriteLine(FindHighestTotalOfThreeConsecutiveNumbers([10, -5, 3, 2]) == 8);
        // Console.WriteLine(FindHighestTotalOfThreeConsecutiveNumbers([-5, -2, -10, -1]) == -13);
        // Console.WriteLine(FindHighestTotalOfThreeConsecutiveNumbers([1, 2]) == null);
        // Console.WriteLine(FindHighestTotalOfThreeConsecutiveNumbers([]) == null);
        // Console.WriteLine(FindHighestTotalOfThreeConsecutiveNumbers([]) == null);

        // Create Initials 
        // Console.WriteLine(CreateInitials("Paul mcKinley") == "PM");
        // Console.WriteLine(CreateInitials("john michael smith") == "JMS");
        // Console.WriteLine(CreateInitials(" sarah connor ") == "SC");
        // Console.WriteLine(CreateInitials("A") == "A");
        // Console.WriteLine(CreateInitials("") == "");
        // Console.WriteLine(CreateInitials(" ") == "");
        // Console.WriteLine(CreateInitials(null!) == "");

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
