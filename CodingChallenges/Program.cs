public class Program
{

    public static int CountValidPrices_RunFour(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string [] splitString = input.Split([','], StringSplitOptions.RemoveEmptyEntries);

        foreach(string str in splitString)
        {
            if(int.TryParse(str.Trim(), out int result))
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
        //Count Valid Prices
        Console.WriteLine(CountValidPrices_RunFour("10, 20, 0, -5, hello") == 2);
        Console.WriteLine(CountValidPrices_RunFour("0, -1, abc") == 0);
        Console.WriteLine(CountValidPrices_RunFour(" 5, 15 , test, 25 ") == 3);
        Console.WriteLine(CountValidPrices_RunFour("") == 0);
        
        

        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
