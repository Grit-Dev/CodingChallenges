using System.Diagnostics.Metrics;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {

        /*
         * 1 coding challenge warm-up
         * main OOP / classes / objects block
         * 1 optional coding challenge if fresh
         */

        /*
            NEXT CHALLENGES
            PHASE 2: OOP / CLASSES / OBJECTS

            ==================================================
            1. CODING WARM-UP: FIND FIRST WORD WITH ALL UNIQUE LETTERS
            ==================================================

            * Return the first word containing no repeated letters.
            * Example: "hello apple cat dog" -> "cat"
            * Example: "book moon tree" -> ""
            * Example: "Apple SUN hello" -> "SUN"
            * Return "" for null or empty.
            * Case-insensitive comparison.
            * Preserve original casing.
            * Split is allowed.
            * Use nested loops.
            * No HashSet or Dictionary.


            ==================================================
            2. OOP CHALLENGE: CREATE A CARD CLASS
            ==================================================

            Create a class named Card.

            It should have these properties:

            * string Name
            * string Rarity
            * int Attack

            Add a constructor that accepts:

            * name
            * rarity
            * attack

            Example:

            Card card = new Card(
                "Johnny Silverhand",
                "Iconic",
                95
            );

            Expected:

            card.Name   -> "Johnny Silverhand"
            card.Rarity -> "Iconic"
            card.Attack -> 95


            ==================================================
            3. OOP CHALLENGE: CREATE A CARD COLLECTION
            ==================================================

            Create a class named CardCollection.

            It should contain:

            * A List<Card> called Cards.

            Add this method:

            public void AddCard(Card card)

            Requirements:

            * Add the supplied card to Cards.
            * Do not add null cards.

            Example:

            CardCollection collection = new CardCollection();

            collection.AddCard(
                new Card("Johnny Silverhand", "Iconic", 95)
            );

            Expected:

            collection.Cards.Count -> 1


            ==================================================
            4. OOP CHALLENGE: FIND HIGHEST ATTACK CARD
            ==================================================

            Add this method to CardCollection:

            public Card? FindHighestAttackCard()

            Requirements:

            * Return the Card with the highest Attack.
            * If two cards tie, return the first card.
            * Return null if there are no cards.
            * Do not use LINQ.

            Example:

            Johnny Silverhand -> 95
            Judy Alvarez       -> 70
            Adam Smasher       -> 100

            Expected:

            Adam Smasher


            ==================================================
            5. OOP CHALLENGE: FIND CARDS BY RARITY
            ==================================================

            Add this method to CardCollection:

            public List<Card> FindCardsByRarity(string rarity)

            Requirements:

            * Return all cards matching the supplied rarity.
            * Comparison must be case-insensitive.
            * Preserve the original Card objects.
            * Return an empty List<Card> if none match.
            * Return an empty List<Card> if rarity is null or empty.
            * Do not use LINQ.

            Example:

            Johnny Silverhand -> Iconic
            Adam Smasher       -> Iconic
            Judy Alvarez       -> Rare

            FindCardsByRarity("iconic")

            Expected:

            Johnny Silverhand
            Adam Smasher


            ==================================================
            6. OOP CHALLENGE: REMOVE CARD BY NAME
            ==================================================

            Add this method to CardCollection:

            public bool RemoveCardByName(string name)

            Requirements:

            * Find the first card matching the supplied name.
            * Comparison must be case-insensitive.
            * Remove that card.
            * Return true if a card was removed.
            * Return false if no matching card exists.
            * Return false if name is null or empty.
            * Do not use LINQ.

            Example:

            Cards:

            Johnny Silverhand
            Judy Alvarez
            Adam Smasher

            RemoveCardByName("judy alvarez")

            Expected:

            true

            Remaining:

            Johnny Silverhand
            Adam Smasher


            ==================================================
            7. OPTIONAL STRETCH: CALCULATE AVERAGE ATTACK
            ==================================================

            Add this method to CardCollection:

            public double CalculateAverageAttack()

            Requirements:

            * Return the average Attack value of all cards.
            * Return 0 if the collection is empty.
            * Do not use LINQ.

            Example:

            Attack values:

            100
            80
            60

            Expected:

            80


            ==================================================
            8. OPTIONAL CODING REVISION IF STILL FRESH
            ==================================================

            FIND WORD WITH MOST UNIQUE CHARACTERS

            * Return the word containing the highest number of unique characters.
            * Example: "abc abcd" -> "abcd"
            * Example: "apple banana card" -> "apple"
            * Example: "HELLO CyberPunk world" -> "CyberPunk"
            * If tied, return the first word.
            * Case-insensitive comparison.
            * Preserve original casing.
            * Return "" for null or empty.
            * You may use List<char>.Contains().
            * Remember to reset character tracking for every word.
        */

    }
}
