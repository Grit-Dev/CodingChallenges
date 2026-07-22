public class Program
{
    public static void Main(string[] args)
    {
        /*
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
