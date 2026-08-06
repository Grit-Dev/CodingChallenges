public class Program
{

    public static int CountValidPrices_RunFour(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string[] splitString = input.Split([','], StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            if (int.TryParse(str.Trim(), out int result))
            {
                if (result > 0)
                {
                    counter++;
                }
            }
        }

        return counter;
    }

    public static string MaskCodeExceptLastThree_RunThree(string code)
    {
        if (string.IsNullOrWhiteSpace(code))
        {
            return "";
        }

        code = code.Trim();

        if (code.Length <= 3)
        {
            return code;
        }

        int charactersLeftOver = code.Length - 3;

        string asterisks = new string('*', charactersLeftOver);

        string lastThreeCharacters = code.Substring(charactersLeftOver);

        return asterisks + lastThreeCharacters;
    }
    public static void Main(string[] args)
    {
        // Mask Code Except Last Three:
        Console.WriteLine(MaskCodeExceptLastThree_RunThree("ABCDEFG") == "****EFG");
        Console.WriteLine(MaskCodeExceptLastThree_RunThree("123456") == "***456");
        Console.WriteLine(MaskCodeExceptLastThree_RunThree("ABC") == "ABC");
        Console.WriteLine(MaskCodeExceptLastThree_RunThree("") == "");

        //Count Valid Prices
        Console.WriteLine(CountValidPrices_RunFour("10, 20, 0, -5, hello") == 2);
        Console.WriteLine(CountValidPrices_RunFour("0, -1, abc") == 0);
        Console.WriteLine(CountValidPrices_RunFour(" 5, 15 , test, 25 ") == 3);
        Console.WriteLine(CountValidPrices_RunFour("") == 0);



        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
