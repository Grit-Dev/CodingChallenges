namespace CodingChallenges.Challenges.Phase_02_OOP.shared
{
    public class CardShop
    {
        public List<Card> Inventory { get; } = [];

        public void AddCard(Card card)
        {
            if (card == null)
            {
                return;
            }

            Inventory.Add(card);
        }

        public bool BuyCard(Player player, string cardName)
        {
            if (player == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(cardName))
            {
                return false;
            }

            Card? targetedCard = null;

            foreach (Card card in Inventory)
            {
                if (card.Name.Equals(
                    cardName,
                    StringComparison.OrdinalIgnoreCase))
                {
                    targetedCard = card;
                    break;
                }
            }

            if (targetedCard == null)
            {
                return false;
            }

            if (!player.BuyCard(targetedCard))
            {
                return false;
            }

            Inventory.Remove(targetedCard);
            return true;
        }

        public Card? FindMostExpensiveCard()
        {
            if (Inventory.Count == 0)
            {
                return null;
            }

            Card mostExpensiveCard = Inventory[0];

            for (int index = 1; index < Inventory.Count; index++)
            {
                if (Inventory[index].Price > mostExpensiveCard.Price)
                {
                    mostExpensiveCard = Inventory[index];
                }
            }

            return mostExpensiveCard;
        }
    }
}