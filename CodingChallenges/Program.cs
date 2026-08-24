using System.Diagnostics.Tracing;

public class Program
{
    public static int CountNumbersEndingInFive(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            string digitToString = digit.ToString();

            if (digitToString.EndsWith('5'))
            {
                counter++;
            }
        }

        return counter;
    }
    public static int CountValidEmployeeCodes(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string[] splitString = input.Split([','], StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim();

            if (strTrimmed.Length == 8 &&
            strTrimmed.StartsWith("EMP-", StringComparison.OrdinalIgnoreCase))
            {
                string lastEndOfString = strTrimmed[4..];

                if (int.TryParse(lastEndOfString, out int _))
                {
                    counter++;
                }
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        //Count Valid Employee Codes = Stirng Parsing: 
        Console.WriteLine(CountValidEmployeeCodes("EMP-1234, EMP-9999, BAD-1234") == 2);
        Console.WriteLine(CountValidEmployeeCodes("emp-0001, EMP-12A4, EMP-12345") == 1);
        Console.WriteLine(CountValidEmployeeCodes("hello, EMP-7777") == 1);
        Console.WriteLine(CountValidEmployeeCodes("") == 0);
        Console.WriteLine(CountValidEmployeeCodes(" ") == 0);
        Console.WriteLine(CountValidEmployeeCodes(null!) == 0);
        
        // Count Numbers Ending in Five
        // Console.WriteLine(CountNumbersEndingInFive([5, 15, 20, -25, 100 ]) == 3);
        // Console.WriteLine(CountNumbersEndingInFive([ 1, 2, 3, 4 ]) == 0);
        // Console.WriteLine(CountNumbersEndingInFive([105, 205, 305 ]) == 3);
        // Console.WriteLine(CountNumbersEndingInFive(null!) == 0);
        // Console.WriteLine(CountNumbersEndingInFive([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
