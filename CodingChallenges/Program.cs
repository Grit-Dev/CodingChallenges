using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Text;

public class Program
{
    // PMG TODO: Redo - Bug: 
    public static string RemoveConsecutiveDuplicateCharacters(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        List<char> newList = [];
        StringBuilder stringBuilder = new StringBuilder();

        foreach (char character in pInputValue)
        {
            if (!newList.Contains(character))
            {
                newList.Add(character);
                stringBuilder.Append(character);
            }
        }

        return stringBuilder.ToString();
    }

    public static void Main(string[] args)
    {
        //// 5. Remove Consecutive Duplicate Characters
        //Console.WriteLine($"aaabbc should return abc => Answer: {RemoveConsecutiveDuplicateCharacters("aaabbc")}");
        //Console.WriteLine($"helloo should return helo => Answer: {RemoveConsecutiveDuplicateCharacters("helloo")}");
        //Console.WriteLine($"ababa should return ababa => Answer: {RemoveConsecutiveDuplicateCharacters("ababa")}");
        //Console.WriteLine($"a should return a => Answer: {RemoveConsecutiveDuplicateCharacters("a")}");
        //Console.WriteLine($"Empty string should return empty => Answer: {RemoveConsecutiveDuplicateCharacters("")}");
        //Console.WriteLine($"Null should return empty => Answer: {RemoveConsecutiveDuplicateCharacters(null!)}");
    }
}
