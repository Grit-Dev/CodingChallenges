public class Program
{
    public static int CountDigitsFromString(string pInputValue)
    {
        int count = 0;

        if (string.IsNullOrEmpty(pInputValue))
        {
            return count;
        }


        foreach (char character in pInputValue)
        {
            if (char.IsDigit(character))
            {
                count++;
            }
        }

        return count;
    }

    public static string ReverseString(string pInputValue)
    {
        string answer = string.Empty;

        if (String.IsNullOrEmpty(pInputValue))
        {
            return "Input is empty. Please ensure value is sent in.";
        }

        for (int counter = pInputValue.Length - 1; counter >= 0; counter--)
        {
            answer = answer + pInputValue[counter];
        }
        

        return answer;
    }



    public static void Main(string[] args)
    {
        // PMG TODO: Clean up as it becomes too lengthy
        // PMG TODO: Eventually start writing unit tests

        //// Counting Vowels
        //Console.WriteLine($"Hello vowels are: {CountingVowels("Hello")}");
        //Console.WriteLine($"Cyberpunk vowels are: {CountingVowels("Cyberpunk")}");
        //Console.WriteLine($"APPLE vowels are: {CountingVowels("APPLE")}");
        //Console.WriteLine($" \"\" vowels are: {CountingVowels("")}");
        //Console.WriteLine($" Why vowels are: {CountingVowels("why")}");


        //// Palindrome: 
        //Console.WriteLine($"RaceCar outcome for Palindrome: {IsPalindrome("RaceCar")}");


        //// Counting Digits:
        //Console.WriteLine($"Count Digits From string should be 3 => Answer: {CountDigitsFromString("abc123")}");

        // ReverseString:

        Console.WriteLine($"Reverse String => olleh Answer: {ReverseString("Hello")}");
    }
}
