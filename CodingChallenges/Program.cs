using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Text;

public class Program
{
    //PMG TODO: This is wrong. Need to come up with a new way to complete this challenge
    public static bool AreStringsAnagrams(string pInputValue, string pInputValueComparison)
    {
        if (pInputValue == null || pInputValueComparison == null)
        {
            return false;
        }

        if (pInputValue == "" && pInputValueComparison == "")
        {
            return true;
        }

        List<char> charsListOfInputValue = [];

        foreach (char character in pInputValue)
        {
            charsListOfInputValue.Add(character);
        }

        foreach (char character in pInputValueComparison)
        {
            if (!charsListOfInputValue.Contains(character))
            {
                return false;
            }
        }

        return true;
    }
    public static void Main(string[] args)
    {
        // Optional Stretch: Are Strings Anagrams
        Console.WriteLine($"listen and silent should return true => Answer: {AreStringsAnagrams("listen", "silent") == true}");
        Console.WriteLine($"triangle and integral should return true => Answer: {AreStringsAnagrams("triangle", "integral") == true}");
        Console.WriteLine($"hello and world should return false => Answer: {AreStringsAnagrams("hello", "world") == false}");
        Console.WriteLine($"APPLE and PAPEL should return true if case-insensitive => Answer: {AreStringsAnagrams("APPLE", "PAPEL") == true}");
        Console.WriteLine($"empty and empty should return true => Answer: {AreStringsAnagrams("", "") == true}");
        Console.WriteLine($"null and test should return false => Answer: {AreStringsAnagrams(null!, "test") == false}");
        Console.WriteLine($"test and null should return false => Answer: {AreStringsAnagrams("test", null!) == false}");
    }
}
