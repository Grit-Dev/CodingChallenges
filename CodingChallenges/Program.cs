using CodingChallenges.Challenges;
using CodingChallenges.Challenges.Phase_02_OOP;

public class Program
{
    public static string FindFirstWordWithExactlyTwoRepeatedCharacters(string pInputValue)
    {
        if(string.IsNullOrWhiteSpace(pInputValue))
        {
            return "";
        }

        const int REPEATEDCHARACTERLIMIT = 2;
        string [] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach(string word in splitString)
        {
            List<char> uniqueCharactersList = [];
            int repeatedCharacter = 0;
            string wordLowered = word.ToLower();

            for(int outterIndex = 0; outterIndex <= wordLowered.Length -1; outterIndex++)
            {
                char currentCharacter = wordLowered[outterIndex];

                if(!uniqueCharactersList.Contains(currentCharacter))
                {
                    uniqueCharactersList.Add(currentCharacter);
                }
                else
                {
                    repeatedCharacter++;
                }
            }

                if(repeatedCharacter == REPEATEDCHARACTERLIMIT)
                {
                    return word;
                }
        }

        return "";
    }

    public static string FindWordWithHighestRepeatedCharacterCount(string pInputValue)
    {
        if(string.IsNullOrWhiteSpace(pInputValue))
        {
            return "";
        }

        string [] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int highestRepeatedCharacters = int.MinValue;
        string highestWordRepeatedCharacters = "";


        foreach(string word in splitString)
        {
            int repeatedCharacterCounter = 0;
            List<char> uniqueCharacterList = [];

            string wordLowered = word.ToLower();

            foreach(char character in wordLowered)
            {
                if(!uniqueCharacterList.Contains(character))
                {
                    uniqueCharacterList.Add(character);
                }
                else
                {
                    repeatedCharacterCounter++;
                }
            }

            if(repeatedCharacterCounter > highestRepeatedCharacters)
            {
                highestRepeatedCharacters = repeatedCharacterCounter;
                highestWordRepeatedCharacters = word;
            }

        }

        return highestWordRepeatedCharacters;
    }

    public static void Main(string[] args)
    {
        // 2. FindWordWithHighestRepeatedCharacterCount
        // Tests null/whitespace, highest repeat count, ties, no repeats, and original casing
        Console.WriteLine($"'{FindWordWithHighestRepeatedCharacterCount(null)}'");              // Expected: ''
        Console.WriteLine($"'{FindWordWithHighestRepeatedCharacterCount("   ")}'");             // Expected: ''
        Console.WriteLine(FindWordWithHighestRepeatedCharacterCount("cat hello mississippi")); // Expected: mississippi
        Console.WriteLine(FindWordWithHighestRepeatedCharacterCount("book moon tree")); // Expected: book
        Console.WriteLine(FindWordWithHighestRepeatedCharacterCount("book moon")); // Expected: book
        Console.WriteLine(FindWordWithHighestRepeatedCharacterCount("cat dog sun")); // Expected: cat
        Console.WriteLine(FindWordWithHighestRepeatedCharacterCount("MiSSiSSiPPi book")); // Expected: MiSSiSSiPPi



        // Fundamental Challenges
        //var fundamental = new ChallengeSolutionsRunner();
        // fundamental.Run();
        // fundamental.Run_Two();

        // phase 02: Challenges
        // var oopChallenges = new CardCollectionChallenges();
        // oopChallenges.Run();
        // oopChallenges.RunTodaydsTest_16_07_2026();
        // oopChallenges.RunTodaysTest_20_07_2026();
        // oopChallenges.RunTodaysTest_21_07_2026();

        /*
            ============================================================
            TOMORROW'S CHALLENGES
            PHASE 2: OOP / CLASSES / OBJECTS
            WEEK 02 - SET 02
            CARDSHOP FILTERING + METHOD COMPOSITION
            ============================================================

            TODAY'S STRUCTURE:

            1 coding revision challenge
            1 new coding challenge
            5 OOP challenges
            1 optional stretch


            ============================================================
            1. CODING REVISION:
               FIND FIRST WORD WITH EXACTLY TWO REPEATED CHARACTERS
            ============================================================

            Return the first word that has exactly two repeated character
            occurrences.

            Repeated character occurrences means extra appearances after
            the first time a character appears.

            Examples:

            "aabb cat moon" -> "aabb"

            "abc banana aabb" -> "aabb"

            "aaa cat dog" -> "aaa"

            "cat hello book" -> ""


            Requirements:

            * Return "" for null, empty, or whitespace-only input.
            * Case-insensitive comparison.
            * Preserve original word casing.
            * Return the first matching word.
            * Split is allowed.
            * You may use List<char>.
            * No LINQ.
            * No Dictionary.
            * No HashSet.


            ============================================================
            2. NEW CODING CHALLENGE:
               FIND WORD WITH HIGHEST REPEATED CHARACTER COUNT
            ============================================================

            Return the word with the highest number of repeated character
            occurrences.

            Examples:

            "cat hello mississippi" -> "mississippi"

            "book moon tree" -> "book"

            "cat dog sun" -> "cat"


            Requirements:

            * Return "" for null, empty, or whitespace-only input.
            * Case-insensitive comparison.
            * Preserve original casing.
            * If tied, return the first word.
            * Split is allowed.
            * You may use List<char>.
            * No LINQ.
            * No Dictionary.
            * No HashSet.


            ============================================================
            3. OOP CHALLENGE:
               FIND ALL CARDS BY RARITY
            ============================================================

            Add this method to CardShop:

            public List<Card> FindCardsByRarity(string rarity)

            Requirements:

            * Return an empty list if rarity is null, empty, or whitespace.
            * Return all cards in Inventory matching the rarity.
            * Comparison must be case-insensitive.
            * Preserve the original Card objects.
            * Return an empty list if no cards match.
            * No LINQ.


            ============================================================
            4. OOP CHALLENGE:
               FIND ALL AFFORDABLE CARDS
            ============================================================

            Add this method to CardShop:

            public List<Card> FindAffordableCards(Player player)

            Requirements:

            * Return an empty list if player is null.
            * Return all cards where card.Price <= player.Credits.
            * Preserve original Card objects.
            * Return an empty list if no cards are affordable.
            * No LINQ.


            ============================================================
            5. OOP CHALLENGE:
               CALCULATE TOTAL INVENTORY VALUE
            ============================================================

            Add this method to CardShop:

            public int CalculateTotalInventoryValue()

            Requirements:

            * Add up the Price of every card in Inventory.
            * Return 0 if Inventory is empty.
            * No LINQ.


            Example:

            Johnny Silverhand -> 400
            Judy Alvarez       -> 250
            Adam Smasher       -> 700

            Expected:

            1350


            ============================================================
            6. OOP CHALLENGE:
               FIND HIGHEST ATTACK CARD PLAYER CAN AFFORD
            ============================================================

            Add this method to CardShop:

            public Card? FindHighestAttackCardPlayerCanAfford(Player player)

            Requirements:

            * Return null if player is null.
            * Return null if Inventory is empty.
            * Only consider cards where card.Price <= player.Credits.
            * Return the affordable card with the highest Attack.
            * If tied, return the first one encountered.
            * Return null if no cards are affordable.
            * No LINQ.


            Example:

            Player Credits -> 500

            Inventory:

            Johnny Silverhand -> Attack 95, Price 400
            Adam Smasher       -> Attack 99, Price 700
            Judy Alvarez       -> Attack 70, Price 250

            Expected:

            Johnny Silverhand


            ============================================================
            7. OOP CHALLENGE:
               BUY HIGHEST ATTACK AFFORDABLE CARD
            ============================================================

            Add this method to CardShop:

            public bool BuyHighestAttackAffordableCard(Player player)

            Requirements:

            * Return false if player is null.
            * Use FindHighestAttackCardPlayerCanAfford(player).
            * Return false if no affordable card exists.
            * If a card exists:
                - player buys that card;
                - remove it from Inventory;
                - return true.
            * Do not duplicate the highest-attack search logic.
            * No LINQ.


            ============================================================
            8. OPTIONAL STRETCH:
               FIND AVERAGE PRICE BY RARITY
            ============================================================

            Add this method to CardShop:

            public double CalculateAveragePriceByRarity(string rarity)

            Requirements:

            * Return 0 if rarity is null, empty, or whitespace.
            * Only include cards matching the supplied rarity.
            * Comparison must be case-insensitive.
            * Return 0 if no cards match.
            * No LINQ.


            Example:

            Iconic cards:

            Johnny Silverhand -> 400
            Adam Smasher       -> 700

            Expected:

            550
        */

        // 1. FindFirstWordWithExactlyTwoRepeatedCharacters
        // Tests null/whitespace, first match, case-insensitive comparison, and original casing
        // Console.WriteLine($"'{FindFirstWordWithExactlyTwoRepeatedCharacters(null)}'");          // Expected: ''
        // Console.WriteLine($"'{FindFirstWordWithExactlyTwoRepeatedCharacters("   ")}'");         // Expected: ''
        // Console.WriteLine(FindFirstWordWithExactlyTwoRepeatedCharacters("aabb cat moon"));      // Expected: aabb
        // Console.WriteLine(FindFirstWordWithExactlyTwoRepeatedCharacters("abc banana aabb"));    // Expected: aabb
        // Console.WriteLine(FindFirstWordWithExactlyTwoRepeatedCharacters("aaa cat dog"));        // Expected: aaa
        // Console.WriteLine(FindFirstWordWithExactlyTwoRepeatedCharacters("cat hello book"));     // Expected: ""
        // Console.WriteLine(FindFirstWordWithExactlyTwoRepeatedCharacters("AAbb cat dog"));       // Expected: AAbb


    }
}
