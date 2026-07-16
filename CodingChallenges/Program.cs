using CodingChallenges.Challenges.Phase_02_OOP;

public class Program
{
    public static void Main(string[] args)
    {
        // Fundamental Challenges
        // var fundamental = new ChallengeSolutionsRunner();
        // fundamental.Run();

        // phase 02: Challenges
        var oopChallenges = new CardCollectionChallenges();
        oopChallenges.Run();

        /*
            ============================================================
            NEXT CHALLENGES
            PHASE 2: OOP / CLASSES / OBJECTS
            SET 3: ENCAPSULATION AND CARD SHOP
            ============================================================

            LEARNING FOCUS:

            This set introduces encapsulation.

            Encapsulation means:
            - protect an object's data;
            - stop outside code changing important values directly;
            - use methods to control how values are changed.

            Example:

            Bad:

            player.Credits = -5000;

            Better:

            player.TrySpendCredits(500);

            The Player class should control its own Credits.


            TODAY'S STRUCTURE:

            1 coding revision challenge
            1 new coding challenge
            5 OOP challenges
            1 optional stretch


            ============================================================
            1. CODING REVISION:
               FIND MOST COMMON WORD LENGTH AND COUNT
            ============================================================

            Find the word length that occurs most frequently.

            Return the result in this format:

            "Length:3 Count:3"


            Example:

            "cat dog sun elephant"

            Word lengths:

            cat      -> 3
            dog      -> 3
            sun      -> 3
            elephant -> 8

            Expected:

            "Length:3 Count:3"


            Another example:

            "I am Paul John"

            Word lengths:

            I    -> 1
            am   -> 2
            Paul -> 4
            John -> 4

            Expected:

            "Length:4 Count:2"


            Requirements:

            * Return "" for null, empty, or whitespace-only input.
            * Split is allowed.
            * Use List<int>.
            * If two lengths have the same highest frequency,
              return the first word length encountered.
            * No LINQ.
            * No Dictionary.
            * No HashSet.


            ============================================================
            2. NEW CODING CHALLENGE:
               COUNT WORDS WITH MORE UNIQUE THAN REPEATED CHARACTERS
            ============================================================

            Return the number of words where the number of unique
            characters is greater than the number of repeated character
            occurrences.


            Example:

            "cat hello book"

            cat:
            Unique characters = 3
            Repeated occurrences = 0
            Count this word.

            hello:
            Unique characters = 4
            Repeated occurrences = 1
            Count this word.

            book:
            Unique characters = 3
            Repeated occurrences = 1
            Count this word.

            Expected:

            3


            Another example:

            "aaa book cat"

            aaa:
            Unique characters = 1
            Repeated occurrences = 2
            Do not count.

            book:
            Unique characters = 3
            Repeated occurrences = 1
            Count.

            cat:
            Unique characters = 3
            Repeated occurrences = 0
            Count.

            Expected:

            2


            Requirements:

            * Return 0 for null, empty, or whitespace-only input.
            * Comparison must be case-insensitive.
            * Split is allowed.
            * You may use List<char>.
            * Reset all per-word tracking for every new word.
            * No LINQ.
            * No Dictionary.
            * No HashSet.


            ============================================================
            3. OOP CHALLENGE:
               ENCAPSULATE PLAYER CREDITS
            ============================================================

            Update your Player class.

            Change Credits from:

            public int Credits { get; set; }

            To:

            public int Credits { get; private set; }


            Requirements:

            * Code outside Player can read Credits.
            * Code outside Player cannot directly change Credits.
            * Only Player methods can change Credits.


            Example:

            Player player = new Player("V", 1000);

            Console.WriteLine(player.Credits);

            Expected:

            1000


            This should no longer compile:

            player.Credits = 5000;


            ============================================================
            4. OOP CHALLENGE:
               ADD CREDITS TO PLAYER
            ============================================================

            Add this method to Player:

            public void AddCredits(int amount)


            Requirements:

            * Add amount to Credits.
            * Do nothing if amount is 0.
            * Do nothing if amount is negative.


            Example:

            Player player = new Player("V", 1000);

            player.AddCredits(500);

            Expected:

            player.Credits -> 1500


            Example:

            player.AddCredits(-500);

            Expected:

            player.Credits remains unchanged.


            ============================================================
            5. OOP CHALLENGE:
               TRY TO SPEND CREDITS
            ============================================================

            Add this method to Player:

            public bool TrySpendCredits(int amount)


            Requirements:

            * Return false if amount is 0.
            * Return false if amount is negative.
            * Return false if the player does not have enough Credits.

            If the player has enough Credits:

            * subtract amount from Credits;
            * return true.


            Example:

            Player player = new Player("V", 1000);

            bool result = player.TrySpendCredits(400);

            Expected:

            result -> true
            player.Credits -> 600


            Example:

            Player player = new Player("V", 100);

            bool result = player.TrySpendCredits(400);

            Expected:

            result -> false
            player.Credits -> 100


            ============================================================
            6. OOP CHALLENGE:
               REFACTOR BUY CARD TO USE TRYSPENDCREDITS
            ============================================================

            Update your existing Player BuyCard method.

            Current method:

            public bool BuyCard(Card card)


            Requirements:

            * Return false if card is null.
            * Use TrySpendCredits(card.Price) inside BuyCard.
            * If TrySpendCredits succeeds:
                - add the card to OwnedCards;
                - return true.
            * If TrySpendCredits fails:
                - do not add the card;
                - return false.


            Example:

            Player player = new Player("V", 1000);

            Card johnny = new Card(
                "Johnny Silverhand",
                "Iconic",
                95,
                400
            );

            bool result = player.BuyCard(johnny);

            Expected:

            result -> true
            player.Credits -> 600
            player.OwnedCards.Count -> 1


            ============================================================
            7. OOP CHALLENGE:
               CREATE A CARD SHOP CLASS
            ============================================================

            Create a new class named:

            CardShop


            Give it this property:

            public List<Card> Inventory { get; }


            The Inventory list should start empty.


            Add this method:

            public void AddCard(Card card)


            Requirements:

            * Add the supplied Card to Inventory.
            * Do not add null cards.
            * Do not throw an exception for null.
            * Simply return without adding anything.


            Example:

            CardShop shop = new CardShop();

            Card johnny = new Card(
                "Johnny Silverhand",
                "Iconic",
                95,
                400
            );

            shop.AddCard(johnny);

            Expected:

            shop.Inventory.Count -> 1


            ============================================================
            8. OPTIONAL STRETCH:
               BUY CARD FROM SHOP
            ============================================================

            Add this method to CardShop:

            public bool BuyCard(
                Player player,
                string cardName
            )


            Requirements:

            * Return false if player is null.
            * Return false if cardName is null, empty, or whitespace.
            * Find the first Card in Inventory whose Name matches cardName.
            * Comparison must be case-insensitive.
            * Return false if no matching Card exists.
            * Return false if the player cannot afford the Card.

            If purchase succeeds:

            * Player spends the Card.Price.
            * Card is added to Player.OwnedCards.
            * Card is removed from shop Inventory.
            * Return true.

            Do not use LINQ.


            Example:

            Player player = new Player("V", 1000);

            CardShop shop = new CardShop();

            Card johnny = new Card(
                "Johnny Silverhand",
                "Iconic",
                95,
                400
            );

            shop.AddCard(johnny);

            bool result = shop.BuyCard(
                player,
                "johnny silverhand"
            );

            Expected:

            result -> true
            player.Credits -> 600
            player.OwnedCards.Count -> 1
            shop.Inventory.Count -> 0


            ============================================================
            9. OPTIONAL EXTRA:
               FIND MOST EXPENSIVE CARD IN SHOP
            ============================================================

            Add this method to CardShop:

            public Card? FindMostExpensiveCard()


            Requirements:

            * Return the Card with the highest Price.
            * Return null if Inventory is empty.
            * If multiple cards tie, return the first card encountered.
            * Do not use LINQ.


            Example:

            Johnny Silverhand -> 400
            Judy Alvarez       -> 250
            Adam Smasher       -> 700

            Expected:

            Adam Smasher
        */
    }
}
