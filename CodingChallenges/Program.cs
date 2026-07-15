using CodingChallenges.Challenges;
using CodingChallenges.Challenges.Phase_02_OOP;
using System.Diagnostics.Metrics;
using System.Text;

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
            SET 2: PLAYER AND CARDS
            ============================================================

            TODAY'S STRUCTURE:

            1 coding revision challenge
            1 new coding challenge
            4 main OOP challenges
            1 optional OOP stretch


            ============================================================
            1. CODING REVISION:
               FIND WORD WITH MOST UNIQUE CHARACTERS
            ============================================================

            Return the word containing the highest number of unique
            characters.

            Examples:

            "abc abcd"
            -> "abcd"

            "apple banana card"
            -> "apple"

            "HELLO CyberPunk world"
            -> "CyberPunk"


            Requirements:

            * Return "" for null or empty input.
            * Comparison must be case-insensitive.
            * Preserve the original casing of the returned word.
            * If there is a tie, return the first word.
            * Split is allowed.
            * You may use List<char>.Contains().
            * Do not use LINQ.
            * Do not use Dictionary.
            * Do not use HashSet.
            * Reset character tracking for every new word.


            ============================================================
            2. NEW CODING CHALLENGE:
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

            * Return "" for null or empty input.
            * Split is allowed.
            * If two word lengths have the same highest frequency,
              return the first word length encountered.
            * You may use List<int>.
            * You may use StringBuilder.
            * No LINQ.
            * No Dictionary.
            * No HashSet.


            ============================================================
            3. OOP CHALLENGE:
               CREATE A PLAYER CLASS
            ============================================================

            Create a new class named:

            Player


            Give it these properties:

            * string Name
            * int Credits
            * List<Card> OwnedCards


            Add a constructor accepting:

            * name
            * credits


            Requirements:

            * Name should be set from the constructor.
            * Credits should be set from the constructor.
            * OwnedCards should start as an empty List<Card>.


            Example:

            Player player = new Player(
                "V",
                1000
            );


            Expected:

            player.Name
            -> "V"

            player.Credits
            -> 1000

            player.OwnedCards.Count
            -> 0


            ============================================================
            4. OOP CHALLENGE:
               ADD CARD TO PLAYER
            ============================================================

            Add this method to Player:

            public void AddCard(Card card)


            Requirements:

            * Add the supplied Card to OwnedCards.
            * Do not add null cards.
            * Do not throw an exception for null.
            * Simply return without adding anything.


            Example:

            Player player = new Player(
                "V",
                1000
            );

            Card johnny = new Card(
                "Johnny Silverhand",
                "Iconic",
                95
            );

            player.AddCard(johnny);


            Expected:

            player.OwnedCards.Count
            -> 1


            ============================================================
            5. OOP CHALLENGE:
               FIND PLAYER'S STRONGEST CARD
            ============================================================

            Add this method to Player:

            public Card? FindStrongestCard()


            Requirements:

            * Return the Card with the highest Attack value.
            * If multiple cards tie, return the first card encountered.
            * Return null when OwnedCards is empty.
            * Do not use LINQ.


            Example:

            Player owns:

            Johnny Silverhand -> 95
            Judy Alvarez       -> 70
            Adam Smasher       -> 100


            Expected:

            Adam Smasher


            ============================================================
            6. OOP CHALLENGE:
               BUY A CARD
            ============================================================

            First, update the Card class.

            Add this property:

            * int Price


            Update the Card constructor so it accepts:

            * name
            * rarity
            * attack
            * price


            Example:

            Card johnny = new Card(
                "Johnny Silverhand",
                "Iconic",
                95,
                400
            );


            Then add this method to Player:

            public bool BuyCard(Card card)


            Requirements:

            * Return false if card is null.

            * Return false if the player does not have enough Credits.

            * If the player has enough Credits:

                - subtract Card.Price from Credits;
                - add the Card to OwnedCards;
                - return true.


            Example:

            Player:

            Name:
            "V"

            Credits:
            1000


            Card:

            Name:
            "Johnny Silverhand"

            Price:
            400


            Call:

            player.BuyCard(johnny);


            Expected:

            true

            player.Credits
            -> 600

            player.OwnedCards.Count
            -> 1


            Another example:

            Player Credits:
            100

            Card Price:
            400


            Expected:

            false

            Credits remain:
            100

            OwnedCards remains empty.


            ============================================================
            7. OPTIONAL OOP STRETCH:
               TRANSFER CARD BETWEEN PLAYERS
            ============================================================

            Add this method to Player:

            public bool TransferCardTo(
                string cardName,
                Player receivingPlayer
            )


            Requirements:

            * Return false if cardName is null or empty.

            * Return false if receivingPlayer is null.

            * Find the first owned Card whose Name matches cardName.

            * Comparison must be case-insensitive.

            * Remove the Card from the current player's OwnedCards.

            * Add the SAME Card object to the receiving player's
              OwnedCards.

            * Return true when successful.

            * Return false if no matching Card exists.

            * Do not use LINQ.


            Example:

            Player one:

            Name:
            V

            Owned cards:

            Johnny Silverhand
            Judy Alvarez


            Player two:

            Name:
            Jackie

            Owned cards:

            None


            Call:

            playerOne.TransferCardTo(
                "johnny silverhand",
                playerTwo
            );


            Expected:

            true


            playerOne.OwnedCards:

            Judy Alvarez


            playerTwo.OwnedCards:

            Johnny Silverhand
        */
    }
}
