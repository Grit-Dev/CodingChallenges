public class Program
{
    public static int CountValidPrices_RunThree(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string [] splitString = input.Split([','], StringSplitOptions.RemoveEmptyEntries);

        foreach(var str in splitString)
        {
            if(int.TryParse(str, out int result))
            {
                if(result > 0)
                {
                    counter++;
                }
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Count Valid Prices
        Console.WriteLine(CountValidPrices_RunThree("10, 20, 0, -5, hello") == 2);
        Console.WriteLine(CountValidPrices_RunThree("0, -1, abc") == 0);
        Console.WriteLine(CountValidPrices_RunThree(" 5, 15 , test, 25 ") == 3);
        Console.WriteLine(CountValidPrices_RunThree(null!) == 0);

        //JsonDataSanitizerRunner.Run();
    }

}
 