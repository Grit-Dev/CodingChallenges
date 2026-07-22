public class Program
{
    public static char FindFirstWordWithRepeatedCharactersAppearingTwice(string pInputValue)
    {
        if(string.IsNullOrWhiteSpace(pInputValue))
        {
            return '\0';
        }

        List<char> cleanedList = [];
        pInputValue = pInputValue.ToLower();

        foreach(char character in pInputValue)
        {
            if(!char.IsWhiteSpace(character))
            {
                cleanedList.Add(character);
            }
        };

        for(int outterIndex = 0; outterIndex <= cleanedList.Count -1; outterIndex++)
        {
            int counter = 0;
            char currentCharacter = cleanedList[outterIndex];

            for(int innerIndex = 0; innerIndex <= cleanedList.Count -1; innerIndex++)
            {
                if(currentCharacter == cleanedList[innerIndex])
                {
                    counter++;
                }
            }

            if(counter == 2)
            {
                return currentCharacter;
            }
        }


        return '\0';

    }

    public static void Main(string[] args)
    {
        // NEW CODING CHALLENGE: FIND FIRST CHARACTER THAT APPEARS EXACTLY TWICE
        Console.WriteLine(FindFirstWordWithRepeatedCharactersAppearingTwice("aaa") == '\0');
        Console.WriteLine(FindFirstWordWithRepeatedCharactersAppearingTwice("banana") == 'n');
        Console.WriteLine(FindFirstWordWithRepeatedCharactersAppearingTwice("abca") == 'a');
        Console.WriteLine(FindFirstWordWithRepeatedCharactersAppearingTwice("AabB") == 'a');
        Console.WriteLine(FindFirstWordWithRepeatedCharactersAppearingTwice("hello") == 'l');
        Console.WriteLine(FindFirstWordWithRepeatedCharactersAppearingTwice("abc") == '\0');
        Console.WriteLine(FindFirstWordWithRepeatedCharactersAppearingTwice("aabbcc") == 'a');
        Console.WriteLine(FindFirstWordWithRepeatedCharactersAppearingTwice(null!) == '\0');
        Console.WriteLine(FindFirstWordWithRepeatedCharactersAppearingTwice("   ") == '\0');
        Console.WriteLine(FindFirstWordWithRepeatedCharactersAppearingTwice("abca") == 'a');
        // NEW CODING CHALLENGE: FIND FIRST CHARACTER THAT APPEARS EXACTLY TWICE
        // Fundamental Challenges
        // ChallengeSolutionsRunner.Run();
        // ChallengeSolutionsRunner.Run_Two();

        // phase 02: Challenges
        // PhaseTwoChallengeRunner.Run();
        // PhaseTwoChallengeRunner.RunTodaydsTest_16_07_2026();
        // PhaseTwoChallengeRunner.RunTodaysTest_20_07_2026();
        // PhaseTwoChallengeRunner.CardShopSellingAndStockChallenges_Run_22_07_2026();

        /*
            ============================================================
            NEXT CHALLENGES
            PHASE 2: OOP / CLASSES / OBJECTS
            CARDSHOP SELLING + STOCK RULES
            ============================================================

            TODAY'S STRUCTURE:

            3 coding challenges
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

            "aaa cat dog" -> "aaa"

            "abc banana aabb" -> "aabb"

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
            2. CODING REVISION:
               FIND WORD WITH HIGHEST REPEATED CHARACTER COUNT
            ============================================================

            Return the word with the highest number of repeated character
            occurrences.

            Examples:

            "cat hello mississippi" -> "mississippi"

            "book moon tree" -> "book"

            "cat dog sun" -> "cat"

            "banana apple aabb" -> "banana"


            Requirements:

            * Return "" for null, empty, or whitespace-only input.
            * Case-insensitive comparison.
            * Preserve original word casing.
            * If tied, return the first word.
            * Split is allowed.
            * You may use List<char>.
            * No LINQ.
            * No Dictionary.
            * No HashSet.


            ============================================================
            3. NEW CODING CHALLENGE:
               FIND FIRST CHARACTER THAT APPEARS EXACTLY TWICE
            ============================================================

            Return the first character that appears exactly twice in the
            input string.

            Examples:

            "aabbcc" -> 'a'

            "abca" -> 'a'

            "hello" -> 'l'

            "abc" -> '\0'

            "AabB" -> 'a'


            Requirements:

            * Return '\0' for null, empty, or whitespace-only input.
            * Case-insensitive comparison.
            * Return the lowercase version of the character.
            * Ignore spaces.
            * If multiple characters appear exactly twice, return the
              first one encountered in the original left-to-right order.
            * No LINQ.
            * No Dictionary.
            * No HashSet.


            ============================================================
            4. OOP CHALLENGE:
               ADD HASCARD TO PLAYER
            ============================================================

            Add this method to Player:

            public bool HasCard(string cardName)

            Requirements:

            * Return false if cardName is null, empty, or whitespace.
            * Return true if OwnedCards contains a card with matching Name.
            * Comparison must be case-insensitive.
            * Return false if no match exists.
            * No LINQ.


            ============================================================
            5. OOP CHALLENGE:
               REMOVE CARD FROM PLAYER AND RETURN IT
            ============================================================

            Add this method to Player:

            public Card? RemoveCardByName(string cardName)

            Requirements:

            * Return null if cardName is null, empty, or whitespace.
            * Search OwnedCards for a matching card name.
            * Comparison must be case-insensitive.
            * If found:
                - remove the card from OwnedCards;
                - return the removed Card.
            * If not found:
                - return null.
            * Use a for loop and RemoveAt.
            * Do not remove from a list inside foreach.
            * No LINQ.


            ============================================================
            6. OOP CHALLENGE:
               SELL CARD FROM PLAYER TO SHOP
            ============================================================

            Add this method to CardShop:

            public bool BuyCardFromPlayer(Player player, string cardName)

            This means:
            The shop buys a card from the player.

            Requirements:

            * Return false if player is null.
            * Return false if cardName is null, empty, or whitespace.
            * Use player.RemoveCardByName(cardName).
            * Return false if the player does not own the card.
            * If the card is found:
                - add the card to shop Inventory;
                - give the player credits equal to half the card Price;
                - return true.
            * Use player.AddCredits(...) for adding credits.
            * No LINQ.


            Example:

            Player owns:

            Johnny Silverhand -> Price 400

            Player credits:

            100

            shop.BuyCardFromPlayer(player, "johnny silverhand")

            Expected:

            true

            Player credits:

            300

            Player owned cards:

            0

            Shop inventory:

            contains Johnny Silverhand


            ============================================================
            7. OOP CHALLENGE:
               COUNT TOTAL CARDS OWNED BY PLAYER AND SHOP
            ============================================================

            Add this method to CardShop:

            public int CountTotalCardsInSystem(Player player)

            Requirements:

            * Return Inventory.Count if player is null.
            * Otherwise return:
                shop Inventory count + player OwnedCards count.
            * No LINQ.


            Example:

            Shop inventory count: 3
            Player owned cards count: 2

            Expected:

            5


            ============================================================
            8. OOP CHALLENGE:
               FIND MOST VALUABLE CARD BETWEEN PLAYER AND SHOP
            ============================================================

            Add this method to CardShop:

            public Card? FindMostValuableCardInSystem(Player player)

            Requirements:

            * Look at all cards in shop Inventory.
            * If player is not null, also look at player's OwnedCards.
            * Return the card with the highest Price.
            * If tied, return the first one encountered.
            * Shop inventory should be checked before player cards.
            * Return null if no cards exist anywhere.
            * No LINQ.


            ============================================================
            9. OPTIONAL STRETCH:
               TRANSFER CARD BETWEEN PLAYERS
            ============================================================

            Add this method to Player:

            public bool TransferCardTo(Player receivingPlayer, string cardName)

            Requirements:

            * Return false if receivingPlayer is null.
            * Return false if cardName is null, empty, or whitespace.
            * Use RemoveCardByName(cardName).
            * Return false if this player does not own the card.
            * If found:
                - add the card to receivingPlayer;
                - return true.
            * No LINQ.
        */
    }
}
