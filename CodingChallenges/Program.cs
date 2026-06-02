public class Program
{
    // PMG TO DO: REFACTOR
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

    public static int CountingVowels(string pInputValue)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        int count = 0;

        if (string.IsNullOrEmpty(pInputValue))
        {
            return count;
        }

        pInputValue = pInputValue.ToLower().Trim();

        foreach (var character in pInputValue)
        {
            if (vowels.Contains(character))
            {
                count++;
            }
        }

        return (count);

    }

    public static bool IsPalindrome(string pInputValue)
    {
        int leftCounter = 0;
        int rightCounter = pInputValue.Length - 1;


        if (pInputValue == null)
        {
            return false;
        }

        pInputValue = pInputValue.ToLower().Replace(" ", "");

        while (leftCounter < rightCounter)
        {
            if (pInputValue[leftCounter] != pInputValue[rightCounter])
            {
                return false;
            }

            leftCounter++;
            rightCounter--;
        }

        return true;

    }

    public static int LargestNumber(int[] pInput)
    {

        if (pInput == null || pInput.Length == 0)
        {
            return 0;
        }

        int answer = pInput[0];

        for (int counter = 1; counter < pInput.Length; counter++)
        {
            if (pInput[counter] > answer)
            {
                answer = pInput[counter];
            }
        }

        return answer;
    }

    public static int SumEvenNumbers(int[] pInput)
    {
        int total = 0;

        if (pInput == null || pInput.Length == 0)
        {
            return 0;
        }

        foreach (int value in pInput)
        {   
            if (value % 2 == 0)
            {
                total = total + value;
            }
        }

        return total;

    
    }

    public static int CountingSpaces(string pInputValue)
    {
        const int ZERO = 0;
        int total = 0;

        if (pInputValue == null)
        {
            return ZERO;
        }

        foreach (char characters in pInputValue)
        {
            if (char.IsWhiteSpace(characters))
            {
                total++;
            }
        }

        return total;
    }

    public static int CountingCapitalLetters(string pInputValue)
    {
        int counter = 0;

        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        foreach (char characters in pInputValue)
        {
            if (char.IsUpper(characters))
            {
                counter++;
            }
        }

        return counter;
    }

    public static int CountingWords(string pInputValue)
    {
        int counter = 0;
        bool isInsiderWorld = false;

        foreach (char characters in pInputValue)
        {
            if (char.IsWhiteSpace(characters) == false)
            {
                if (isInsiderWorld == false)
                { 
                    counter++;
                    isInsiderWorld = true;
                }
            }
            else
            {
                isInsiderWorld = false;
            }
        }

        return counter;
    }



    public static void Main(string[] args)
    {
        // PMG TODO: Clean up as it becomes too lengthy
        // PMG TODO: Eventually start writing unit tests

        /*        // Counting Vowels
                Console.WriteLine($"Hello vowels are: {CountingVowels("Hello")}");
                Console.WriteLine($"Cyberpunk vowels are: {CountingVowels("Cyberpunk")}");
                Console.WriteLine($"APPLE vowels are: {CountingVowels("APPLE")}");
                Console.WriteLine($" \"\" vowels are: {CountingVowels("")}");
                Console.WriteLine($" Why vowels are: {CountingVowels("why")}");


                //Palindrome: 
                Console.WriteLine($"RaceCar outcome for Palindrome: {IsPalindrome("RaceCar")}");


                //// Counting Digits:
                //Console.WriteLine($"Count Digits From string should be 3 => Answer: {CountDigitsFromString("abc123")}");

                // ReverseString:
                Console.WriteLine($"Reverse String => olleh Answer: {ReverseString("Hello")}");

                // Find the Largest number: 
                Console.WriteLine($"Largest number => [100, 1, 99 ] Answer: {LargestNumber([100, 1, 99])}");

        */

        /*        // Sum of Even Numbers
                Console.WriteLine($"Sum of Even Numbers  => [1, 2, 3, 4, 5] Answer = 6: {SumEvenNumbers([1, 2, 3, 4,])}");

                //CountSpaces
                Console.WriteLine($"Should be 7. Result: {CountingSpaces("       ")}");
                Console.WriteLine($"Should be 3. Result: {CountingSpaces(" Hello World ")}");
                Console.WriteLine($"Should be 0. Result: {CountingSpaces("")}");
                Console.WriteLine($"Should be 1. Result: {CountingSpaces(" ")}");*/

        // Counting Capitals:
        Console.WriteLine($"Should be 1. Result: {CountingCapitalLetters(" One ")}");
        Console.WriteLine($"Should be 1. Result: {CountingCapitalLetters("One ")}");
        Console.WriteLine($"Should be 2. Result: {CountingCapitalLetters(" Hello World ")}");
        Console.WriteLine($"Should be 9. Result: {CountingCapitalLetters(" I WENT for a WALK today ")}");

        // Counting Words: 
        Console.WriteLine($"Should be 1. Result: {CountingWords(" One ")}");
        Console.WriteLine($"Should be 1. Result: {CountingWords("One ")}");
        Console.WriteLine($"Should be 2. Result: {CountingWords(" Hello World ")}");
        Console.WriteLine($"Should be 6. Result: {CountingWords(" I went for a walk today ")}");


    }
}
